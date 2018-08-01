using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Game;
using MTG.Model.Objects;
using MTG.Model.Zones;
using MTGModel.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model
{
    public class ActiveGame
    {
        #region Variables
        private List<IPendingAction> _PendingActions;
        private List<Player> _Players;
        private List<GamePhases> _SkipPhases;
        private List<GameModifier> _Modifiers;
        private List<Effect> _ActiveEffects;
        private List<AttackingCreature> _Attackers;
        private List<UpkeepRequirement> _UpkeepRequirements;
        #endregion

        #region Properties
        public IReadOnlyCollection<Effect> ActiveEffects { get { return _ActiveEffects.AsReadOnly(); } }
        public IReadOnlyCollection<AttackingCreature> Attackers { get { return _Attackers.AsReadOnly(); } }
        public IReadOnlyCollection<GameModifier> Modifiers { get { return _Modifiers.AsReadOnly(); } }
        public IReadOnlyCollection<IPendingAction> PendingActions { get { return _PendingActions.AsReadOnly(); } }
        public IReadOnlyCollection<Player> Players { get { return _Players.AsReadOnly(); } }
        public IReadOnlyCollection<GamePhases> SkipPhases { get { return _SkipPhases.AsReadOnly(); } }
        public IReadOnlyCollection<UpkeepRequirement> UpkeepRequirements { get { return _UpkeepRequirements.AsReadOnly(); } }

        public Player ActivePlayer 
        {
            get
            {
                return _Players[ActivePlayerIndex];
            }
        }
        public int ActivePlayerIndex { get; set; }
        public GamePhases ActivePhase { get; set; }
        public Ante Ante { get; set; }
        public Exile Exile { get; set; }
        public GameType GameType { get; private set; }
        public GamePhases OverrideNextPhase { get; set; }
        public int TurnSpellCount { get; set; }
        public Stack Stack { get; set; }
        #endregion

        #region Constructors
        public ActiveGame()
        {
            ActivePlayerIndex = 0;
            Ante = new Ante();
            Exile = new Exile();
            Stack = new Stack();
            ActivePhase = GamePhases.None;
            OverrideNextPhase = GamePhases.None;
            
            _PendingActions = new List<IPendingAction>();
            _Players = new List<Player>();
            _SkipPhases = new List<GamePhases>();
            _Modifiers = new List<GameModifier>();
            _ActiveEffects = new List<Effect>();
            _Attackers = new List<AttackingCreature>();
            _UpkeepRequirements = new List<UpkeepRequirement>();
        }
        #endregion

        #region Event Handlers
        private void OnAddCardToZone(object sender, EventArgs e)
        {
            AddCardToZoneEventArgs args = (AddCardToZoneEventArgs)e;
            switch (args.TargetZone)
            {
                case TargetZone.Ante:
                    Ante.Add(args.Card);
                    break;
                case TargetZone.Battlefield:
                    args.ZoneOwner.Battlefield.Add(args.Card);
                    break;
                case TargetZone.Command:
                    args.ZoneOwner.Command.Add(args.Card);
                    break;
                case TargetZone.Exile:
                    Exile.Add(args.Card);
                    break;
                case TargetZone.Graveyard:
                    args.ZoneOwner.Graveyard.Add(args.Card);
                    break;
                case TargetZone.Hand:
                    args.ZoneOwner.Hand.Add(args.Card);
                    break;
                case TargetZone.Library:
                    args.ZoneOwner.Library.Add(args.Card);
                    break;
                case TargetZone.Stack:
                    Stack.Add(args.Card);
                    break;
            }
        }
        private void OnAddPendingAction(object sender, EventArgs e)
        {
            throw new NotImplementedException("ActiveGame.OnAddPendingAction");
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

            throw new NotImplementedException("ActiveGame.OnEffectTrigger");
        }
        #endregion

        #region Methods
        public List<Effect> ActiveEffectsByType(EffectTypes effectType)
        {
            if (effectType == EffectTypes.None)
                return _ActiveEffects;
            else
                return _ActiveEffects.FindAll(o=>o.EffectType == effectType);
        }
        public void AddEffect(Effect effect)
        {
            _ActiveEffects.Add(effect);
        }
        public void AddPlayer(string name, Deck deck)
        {
            //create player
            Player player = new Player(name);
            //add event handlers
            player.OnAddCardToZone += OnAddCardToZone;
            player.OnAddPendingAction += OnAddPendingAction;
            player.OnEffectTrigger += OnEffectTrigger;
            //add deck
            player.SelectDeck(deck);

            _Players.Add(player);
        }
        public void AddToStack(Card card)
        {

            throw new NotImplementedException("ActiveGame.AddToStack");
        }
        public void AddToStack(Effect effect)
        {
            throw new NotImplementedException("ActiveGame.AddToStack");
        }
        public void AddUpkeepRequirement(UpkeepRequirement requirement)
        {
            _UpkeepRequirements.Add(requirement);
        }
        public void EmptyManaPools()
        {
            foreach (Player player in Players)
                player.EmptyManaPool();
        }
        public Card FindCard(int cardId)
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
        public UpkeepRequirement NextUpkeepRequirement()
        {
            UpkeepRequirement retVal = _UpkeepRequirements[0];
            _UpkeepRequirements.RemoveAt(0);
            return retVal;
        }
        public void ProcessDamage()
        {
            foreach (Player player in Players)
                player.ProcessDamage();
        }
        public void ProcessPhase()
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
                case GamePhases.Combat_Damage_FirstStrike:
                    Phases.CombatPhase_CombatDamageStep_FirstStrikeDamage(this, OnEffectTrigger);
                    break;
                case GamePhases.Combat_Damage:
                    Phases.CombatPhase_CombatDamageStep_NormalDamage(this, OnEffectTrigger);
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
        public void RemoveEffects(GamePhases processPhase)
        {
            _ActiveEffects.RemoveAll(o => o.EndingPhase == processPhase);
        }
        public void RemoveModifiers(GameModifier modifier)
        {
            _Modifiers.RemoveAll(o => o == modifier);
        }
        public void RestartGame()
        {
            //reset all remaining players to new game
            throw new NotImplementedException("ActiveGame.RestartGame");
        }
        public void SetGameType(GameType gameType)
        {
            //Apply any game type specific settings
            GameType = gameType;
            switch (GameType)
            {
                case GameType.Melee:
                    break;
            }
        }
        public void SetNextPlayer()
        {
            if (ActivePlayer.AdditionalTurnCount > 0)
                ActivePlayer.AdditionalTurnCount--;
            else 
            {
                int nextIndex = 0;
                if (ActivePlayerIndex != Players.Count - 1)
                    nextIndex = ActivePlayerIndex + 1;
                while (_Players[nextIndex].LoseMessage != null)
                {

                    if (nextIndex != Players.Count - 1)
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