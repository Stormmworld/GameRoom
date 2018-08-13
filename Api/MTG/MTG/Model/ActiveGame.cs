using MTG.DTO.Requests;
using MTG.DTO.Responses;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Game;
using MTG.Model.Objects;
using MTG.Model.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using MTG.DTO.Objects;
using MTG.Model.Pending_Actions;
using MTG.DTO.Requests.CompleteActions;
using MTG.Model.Effects;
using MTG.ArgumentDefintions.Event_Arguments;

namespace MTG.Model
{
    public class ActiveGame
    {
        #region Events
        public event EventHandler OnPendingAction;
        #endregion

        #region Variables
        private List<IPendingAction> _PendingActions;
        private List<Player> _Players;
        private List<GamePhases> _SkipPhases;
        private List<GameModifier> _Modifiers;
        private List<IEffect> _ActiveEffects;
        #endregion

        #region Collection Properties
        internal IReadOnlyCollection<IEffect> ActiveEffects { get { return _ActiveEffects.AsReadOnly(); } }
        internal IReadOnlyCollection<GameModifier> Modifiers { get { return _Modifiers.AsReadOnly(); } }
        internal IReadOnlyCollection<IPendingAction> PendingActions { get { return _PendingActions.AsReadOnly(); } }
        public IReadOnlyCollection<Player> Players { get { return _Players.AsReadOnly(); } }
        internal IReadOnlyCollection<GamePhases> SkipPhases { get { return _SkipPhases.AsReadOnly(); } }
        #endregion

        #region Properties
        internal Combat ActiveCombat { get; set; }
        public Player ActivePlayer 
        {
            get
            {
                return ActivePlayerIndex < 0 ? null : _Players[ActivePlayerIndex];
            }
        }
        internal int ActivePlayerIndex { get; set; }
        public GamePhases ActivePhase { get; internal set; }
        internal Ante Ante { get; set; }
        internal Exile Exile { get; set; }
        internal GameType GameType { get; private set; }
        internal GamePhases OverrideNextPhase { get; set; }
        internal int TurnSpellCount { get; set; }
        internal Stack Stack { get; set; }
        #endregion

        #region Constructors
        public ActiveGame()
        {
            ActivePlayerIndex = -1;
            Ante = new Ante();
            ActiveCombat = new Combat();
            Exile = new Exile();
            Stack = new Stack();
            ActivePhase = GamePhases.None;
            OverrideNextPhase = GamePhases.None;
            
            _PendingActions = new List<IPendingAction>();
            _Players = new List<Player>();
            _SkipPhases = new List<GamePhases>();
            _Modifiers = new List<GameModifier>();
            _ActiveEffects = new List<IEffect>();
        }
        #endregion

        #region Event Handlers
        private void OnAddCardToZone(object sender, EventArgs e)
        {
            AddCardToZoneEventArgs args = (AddCardToZoneEventArgs)e;
            if (args.ZoneOwnerId == new Guid())
                switch (args.TargetZone)
                {
                    case TargetZone.Ante:
                        Ante.Add(args.Card);
                        break;
                    case TargetZone.Exile:
                        Exile.Add(args.Card);
                        break;
                    case TargetZone.Stack:
                        Stack.Add(args.Card);
                        break;
                    default:
                        throw new Exception("Card attempted to add to an unknown zone. " + args.TargetZone.ToString());
                }
            else
                foreach (Player player in _Players)
                    if(player.Id == args.ZoneOwnerId)
                        player.Add(args.Card, args.TargetZone);
        }
        private void OnAddPendingAction(object sender, EventArgs e)
        {
            _PendingActions.Add(((PendingActionEventArgs)e).PendingAction);
            OnPendingAction?.Invoke(this, (PendingActionEventArgs)e);
        }
        private void OnApplyDamage(object sender, EventArgs e)
        {
            ApplyDamageEventArgs args = (ApplyDamageEventArgs)e;
            foreach (Player player in _Players)
                if (args.Target.Type == TargetType.Player && player.Id == args.Target.Id)
                {
                    player.ApplyDamage(args);
                    return;
                }
                else if ((args.Target.Type == TargetType.Card || args.Target.Type == TargetType.Planeswalker) && player.FindCard(args.Target.Id) != null)
                {
                    player.ApplyDamage(args);
                    return;
                }
        }
        private void OnCardDestroyed(object sender, EventArgs e)
        {
            throw new NotImplementedException("OnCardDestroyed");
        }
        private void OnCardEnteredBattlefield(object sender, EventArgs e)
        {
            throw new NotImplementedException("OnCardEnteredBattlefield");
        }
        private void OnCardEnteredGraveYard(object sender, EventArgs e)
        {
            throw new NotImplementedException("OnCardDestroyed");
        }
        private void OnEffectTrigger(object sender, EventArgs e)
        {
            EffectTriggerEventArgs args = (EffectTriggerEventArgs)e;

            // throw new NotImplementedException("ActiveGame.OnEffectTrigger");
        }
        private void OnEffectTriggered(object sender, EventArgs e)
        {
            throw new NotImplementedException("ActiveGame.OnEffectTrigger");
        }
        #endregion

        #region Interfacing Methods
        public ActivateCardResponse ActivateCard(ActivateCardRequest request)
        {
            return new ActivateCardResponse()
            {
                Abilities = FindCard(request.CardId).GetActivatedAbilities(),
                CardId = request.CardId,
            };
        }
        public void Add(string socketId, string playerName, Deck deck)
        {
            Add(new Player(playerName) { SocketId = socketId }, deck);
        }
        public void Add(Player player, Deck deck)
        {
            //add event handlers
            player.OnAddCardToZone += OnAddCardToZone;
            player.OnAddPendingAction += OnAddPendingAction;
            player.OnEffectTrigger += OnEffectTrigger;
            player.OnEffectTriggered += OnEffectTriggered;
            //add deck
            player.SelectDeck(deck);

            _Players.Add(player);
        }
        public CastSpellResponse CastSpell(CastSpellRequest request)
        {
            Player castingPlayer = _Players.FirstOrDefault(o=>o.Id == request.PlayerId);
            if (castingPlayer != null)
                return castingPlayer.CastSpell(request.SpellId);
            return new CastSpellResponse() { Message = "Player not found" };
        }
        public void CompleteAction(ICompleteActionRequest request)
        {
            IPendingAction actionToComplete = _PendingActions.First(o=>o.Id == request.ActionId);
            if (actionToComplete is MulliganPendingAction)
            {
                if (((MulliganCompleteActionRequest)request).Reshuffle)
                {
                    Player mulliganPlayer = _Players.First(o => o.Id == request.ActionPlayerId);
                    mulliganPlayer.Add(new Mulligan(new Target() { Id = request.ActionPlayerId, Type = TargetType.Player }));
                }
                _PendingActions.Remove(actionToComplete);
                if (PendingActions.Count == 0 && _Players.Count > 1)
                {
                    ActivePlayerIndex = (new Random()).Next(0, Players.Count);
                    ActivePhase = GamePhases.Beginning_Untap;
                }
            }
            else
                throw new Exception("ActiveGame.CompleteAction - The request has not been defined yet");
        }
        public void DeclareAttacker(DeclareAttackerRequest request)
        {
            Card attacker = FindCard(request.AttackerId);
            ActiveCombat.AddAttacker(new AttackingCreature(attacker) { Defender = request.Target }, request.JoinBandId);
        }
        public void DeclareBlocker(DeclareBlockerRequest request)
        {
            Card Blocker = FindCard(request.BlockerId);
            ActiveCombat.AddBlocker(Blocker, request.AttackerId, request.BlockerId);
        }
        public void EndCurrentPhase()
        {
            Phases.NextPhase(this);
            if (ActivePhase != GamePhases.None)
                ProcessPhase();
        }
        public CombatResponse GetActiveCombat()
        {
            return new CombatResponse(this);
        }
        public PlayerHand GetPlayerHand(Guid playerId)
        {
            Player player = _Players.First(o => o.Id == playerId);
            return new PlayerHand(player.Hand, player.Id == ActivePlayer.Id, ActivePhase );
        }
        public SelectAbilityResponse SelectAbility(SelectAbilityRequest request)
        {
            Card abilityCard = FindCard(request.CardId);
            Player abilityController = _Players.FirstOrDefault(o => o.Id == abilityCard.ControllerId);
            return abilityController.ActivateAbility(abilityCard.Id, request.AbilityId);
        }
        public void StartGame()
        {
            foreach (Player player in _Players)
            {
                player.DrawCards(player.Hand.InitialSize, GamePhases.None);
                if (player.Hand.LandMulligan())
                    OnAddPendingAction(this, new PendingActionEventArgs() { PendingAction = new MulliganPendingAction() { ActionPlayerId = player.Id } });
            }
            if (PendingActions.Count == 0 && _Players.Count > 1)
            {
                ActivePlayerIndex = (new Random()).Next(0, Players.Count);
                ActivePhase = GamePhases.Beginning_Untap;
            }
        }
        #endregion

        #region Methods
        internal List<IEffect> ActiveEffectsByType(Type effectType)
        {
            return _ActiveEffects.FindAll(o => o.GetType() == effectType);
        }
        internal void AddEffect(IEffect effect)
        {
            switch (effect.Target.Type)
            {
                case TargetType.Player:
                    Player targetPlayer = _Players.First(o=>o.Id == effect.Target.Id);
                    targetPlayer.Add(effect);
                    break;
                case TargetType.Card:
                    Card targetCard = FindCard(effect.Target.Id);
                    Player targetController = _Players.First(o => o.Id == targetCard.ControllerId);
                    targetController.Add(effect);
                    break;
                default:
                    _ActiveEffects.Add(effect);
                    break;
            }
        }
        internal void AddToStack(Card card)
        {

            throw new NotImplementedException("ActiveGame.AddToStack");
        }
        internal void AddToStack(IEffect effect)
        {
            throw new NotImplementedException("ActiveGame.AddToStack");
        }
        internal void EmptyManaPools()
        {
            foreach (Player player in Players)
                player.EmptyManaPool();
        }
        internal Card FindCard(Guid cardId)
        {
            Card foundCard = Exile.Cards.FirstOrDefault(o => o.Id == cardId);
            if (foundCard != null)
                return foundCard;
            foreach (Player player in Players)
            {
                foundCard = player.Hand.Cards.FirstOrDefault(o => o.Id == cardId);
                if (foundCard != null)
                    return foundCard;
                foundCard = player.Library.Cards.FirstOrDefault(o => o.Id == cardId);
                if (foundCard != null)
                    return foundCard;
                foundCard = player.Graveyard.Cards.FirstOrDefault(o => o.Id == cardId);
                if (foundCard != null)
                    return foundCard;
                foundCard = player.Battlefield.Cards.FirstOrDefault(o => o.Id == cardId);
                if (foundCard != null)
                    return foundCard;
                foundCard = player.Command.Cards.FirstOrDefault(o => o.Id == cardId);
                if (foundCard != null)
                    return foundCard;
            }
            return null;
        }
        internal void ProcessDamage()
        {
            throw new NotImplementedException("ActiveGame.ProcessDamage");
        }
        internal void ProcessPhase()
        {
            /*
             * https://mtg.gamepedia.com/Turn_structure
                500.1. A turn consists of five phases, in this order: beginning, precombat main, combat, postcombat main, 
                        and ending. Each of these phases takes place every turn, even if nothing happens during the phase. 
                        The beginning, combat, and ending phases are further broken down into steps, which proceed in order.
                500.2. A phase or step in which players receive priority ends when the stack is empty and all players pass 
                        in succession. Simply having the stack become empty doesn’t cause such a phase or step to end; all 
                        players have to pass in succession with the stack empty. Because of this, each player gets a chance 
                        to add new things to the stack before that phase or step ends.
                500.3. A step in which no players receive priority ends when all specified actions that take place during 
                        that step are completed. The only such steps are the untap step (see rule 502) and certain cleanup 
                        steps (see rule 514).
                500.4. When a step or phase ends, any unused mana left in a player’s mana pool empties. This turn-based 
                        action doesn’t use the stack.
                500.5. When a phase or step ends, any effects scheduled to last “until end of” that phase or step expire. 
                        When a phase or step begins, any effects scheduled to last “until” that phase or step expire. Effects 
                        that last “until end of combat” expire at the end of the combat phase, not at the beginning of the 
                        end of combat step. Effects that last “until end of turn” are subject to special rules; see rule 514.2.
                500.6. When a phase or step begins, any abilities that trigger “at the beginning of” that phase or step 
                        trigger. They are put on the stack the next time a player would receive priority. (See rule 116, 
                        “Timing and Priority.”)
                500.7. Some effects can give a player extra turns. They do this by adding the turns directly after the 
                        specified turn. If a player is given multiple extra turns, the extra turns are added one at a time. 
                        If multiple players are given extra turns, the extra turns are added one at a time, in APNAP order 
                        (see rule 101.4). The most recently created turn will be taken first.
                500.8. Some effects can add phases to a turn. They do this by adding the phases directly after the 
                        specified phase. If multiple extra phases are created after the same phase, the most recently 
                        created phase will occur first.
                500.9. Some effects can add steps to a phase. They do this by adding the steps directly after a specified 
                        step or directly before a specified step. If multiple extra steps are created after the same step, 
                        the most recently created step will occur first.
                500.10. Some effects can cause a step, phase, or turn to be skipped. To skip a step, phase, or turn is to 
                        proceed past it as though it didn’t exist. See rule 614.10.
                500.11. No game events can occur between turns, phases, or steps.
             */
            if (ActivePhase == GamePhases.None)//beginning of game scenario
                ActivePhase = GamePhases.Beginning_Untap;
            switch (ActivePhase)
            {
                case GamePhases.Beginning_Untap:
                    Phases.BegginingPhase_UntapStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Beginning_Upkeep:
                    Phases.BegginingPhase_UpkeepStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Beginning_Draw:
                    Phases.BegginingPhase_UpkeepStep_End(this, OnEffectTrigger);
                    Phases.BegginingPhase_DrawStep(this, OnEffectTrigger);
                    break;
                case GamePhases.PreCombat_Main:
                    Phases.PreCombatMainPhase(this, OnEffectTrigger);
                    break;
                case GamePhases.Combat_Beginning:
                    Phases.CombatPhase_BeginningStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Combat_DeclareAttackers:
                    Phases.CombatPhase_DeclareAttackersStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Combat_DeclareDefenders:
                    Phases.CombatPhase_DeclareBlockersStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Combat_Damage:
                    Phases.CombatPhase_CombatDamageStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Combat_Ending:
                    Phases.CombatPhase_EndStep(this, OnEffectTrigger);
                    break;
                case GamePhases.PostCombat_Main:
                    Phases.PostCombatMainPhase(this, OnEffectTrigger);
                    break;
                case GamePhases.Ending_End:
                    Phases.EndingPhase_EndStep(this, OnEffectTrigger);
                    break;
                case GamePhases.Ending_Cleanup:
                    Phases.EndingPhase_CleanupStep(this, OnEffectTrigger);
                    break;
            }
        }
        internal void RemoveEffects(GamePhases processPhase)
        {
            _ActiveEffects.RemoveAll(o => o.EndingPhase == processPhase);
        }
        internal void RemoveModifiers(GameModifier modifier)
        {
            _Modifiers.RemoveAll(o => o == modifier);
        }
        internal void RestartGame()
        {
            //reset all remaining players to new game
            throw new NotImplementedException("ActiveGame.RestartGame");
        }
        internal void SetGameType(GameType gameType)
        {
            //Apply any game type specific settings
            GameType = gameType;
            switch (GameType)
            {
                case GameType.Melee:
                    break;
            }
        }
        internal void SetNextPlayer()
        {
            if (ActivePlayer.HasEffectType(typeof(AdditionalTurn)))
                ActivePlayer.Remove(typeof(AdditionalTurn));
            else
            {
                int nextIndex = 0;
                if (ActivePlayerIndex != Players.Count - 1)
                    nextIndex = ActivePlayerIndex + 1;
                while (!string.IsNullOrEmpty(_Players[nextIndex].LoseMessage))
                {

                    if (nextIndex == Players.Count - 1)
                        nextIndex = 0;
                    else
                        nextIndex++;
                }
                ActivePlayerIndex = nextIndex;
            }
        }
        #endregion
    }
}