using MTG.Model.Zones;
using MTG.Model.Objects;
using System;
using MTG.Enumerations;
using System.Collections.Generic;
using System.Linq;
using MTG.Interfaces;
using MTG.ArgumentDefintions.Trigger_Arguments;
using MTG.Model.Effects;
using MTG.DTO.Responses;
using MTG.Model.Pending_Actions;
using MTG.Helpers;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Model.Abilities;
using MTG.ArgumentDefintions.ActivationArguments;
using MTG.Model.Counters;
using MTG.DTO.Objects;
using MTG.Interfaces.Ability_Interfaces;
using MTG.ArgumentDefintions.Effect_Triggered_Arguments;

namespace MTG.Model
{
    public class Player
    {
        #region Events
        public event EventHandler OnAddPendingAction, OnAddCardToZone, OnEffectTriggered, OnEffectTrigger, OnApplyDamage;
        #endregion

        #region Properties
        public List<IEffect> ActiveEffects { get; set; }
        public Battlefield Battlefield { get; set; }
        public Command Command { get; set; }
        public bool Conceded { get; set; }
        public List<ICounter> Counters { get; private set; }
        public Deck Deck { get; private set; }
        public bool FailedDraw { get; set; }
        public bool ForceLose { get; set; }
        public Graveyard Graveyard { get; set; }
        public Hand Hand { get; set; }
        public Guid Id { get; set; }
        public Library Library { get; private set; }
        public int Life { get; private set; }
        public string LoseMessage { get; set; }
        public ManaPool ManaPool { get; set; }
        public string Name { get; set; }
        public List<GamePhases> SkipPhases { get; set; }
        public string SocketId { get; set; }
        public int TeamId { get; set;
        }
        #endregion

        #region Constructors
        public Player()
        {
            Id = Guid.NewGuid();
            Battlefield = new Battlefield();
            Battlefield.OnAddCardToZone += Zone_OnAddCardToZone;
            Battlefield.OnEffectTrigger += Zone_OnEffectTrigger;
            Battlefield.OnEffectTriggered += Zone_OnEffectTriggered;
            Battlefield.OnPendingActionTriggered += Zone_OnPendingActionTriggered;
            Command = new Command();
            Command.OnAddCardToZone += Zone_OnAddCardToZone;
            Command.OnEffectTrigger += Zone_OnEffectTrigger;
            Command.OnEffectTriggered += Zone_OnEffectTriggered;
            Command.OnPendingActionTriggered += Zone_OnPendingActionTriggered;
            Graveyard = new Graveyard();
            Graveyard.OnAddCardToZone += Zone_OnAddCardToZone;
            Graveyard.OnEffectTrigger += Zone_OnEffectTrigger;
            Graveyard.OnEffectTriggered += Zone_OnEffectTriggered;
            Graveyard.OnPendingActionTriggered += Zone_OnPendingActionTriggered;
            Hand = new Hand();
            Hand.OnAddCardToZone += Zone_OnAddCardToZone;
            Hand.OnEffectTrigger += Zone_OnEffectTrigger;
            Hand.OnEffectTriggered += Zone_OnEffectTriggered;
            Hand.OnPendingActionTriggered += Zone_OnPendingActionTriggered;
            Library = new Library(Id);
            Library.OnAddCardToZone += Zone_OnAddCardToZone;
            Library.OnEffectTrigger += Zone_OnEffectTrigger;
            Library.OnEffectTriggered += Zone_OnEffectTriggered;
            Library.OnPendingActionTriggered += Zone_OnPendingActionTriggered;
            ResetPlayer();
        }
        public Player(string name):this()
        {
            Name = name;
        }
        #endregion

        #region EventHandlers
        private void Zone_OnAddCardToZone(object sender, EventArgs e)
        {
            AddCardToZoneEventArgs args = (AddCardToZoneEventArgs)e;
                OnAddCardToZone?.Invoke(sender, e);
        }
        private void Zone_OnPendingActionTriggered(object sender, EventArgs e)
        {
            throw new NotImplementedException("Player.Zone_OnPendingActionTriggered");
        }
        private void Zone_OnEffectTriggered(object sender, EventArgs e)
        {
            EffectTriggeredEventArgs args = (EffectTriggeredEventArgs)e;
            if (args.Effect.Target.Type == TargetType.Player && args.Effect.Target.Id == Id)
                Apply(args.Effect);
            else
                OnEffectTrigger?.Invoke(sender, e);
        }
        private void Zone_OnEffectTrigger(object sender, EventArgs e)
        {
            OnEffectTrigger?.Invoke(sender, e);
        }
        #endregion

        #region Methods
        public SelectAbilityResponse ActivateAbility(Guid cardId, Guid abilityId)
        {
            Card card = FindCard(cardId);
            IActivatedAbility ability = (IActivatedAbility)card.Abilities.FirstOrDefault(a => a.Id == abilityId);

            if (ability is ManaSource)
            {
                ManaSourceActivationArgs abilityArgs = new ManaSourceActivationArgs() {ActivatingCardId = card.Id, ActivatingPlayerId = this.Id, CardTypeCount = Battlefield.FilteredCards(o=>o.HasType(((ManaSource)ability).CardTypeMultiplier)).Count };
                return card.ActivateAbility(abilityId, ManaPool, abilityArgs);
            }
            throw new Exception("Player.ActivateAbility - " + ability.ToString() + " has no handler associated with it");
        }
        public void AddLife(int amount)
        {
            Life += amount;

            EffectTriggerEventArgs args = new EffectTriggerEventArgs()
            {
                Args = new LifeGainedTriggerArgs()
                {
                    ActivePlayer = this,
                    LifeGained = amount,
                },
                Trigger = EffectTrigger.Phases_BegginingPhase_UpkeepStep,
            };
            OnEffectTrigger?.Invoke(null, args);
        }
        public void Add(Card card, TargetZone zone)
        {
            switch (zone)
            {
                case TargetZone.Battlefield:
                    Battlefield.Add(card);
                    break;
                case TargetZone.Command:
                    Command.Add(card);
                    break;
                case TargetZone.Graveyard:
                    Graveyard.Add(card);
                    break;
                case TargetZone.Hand:
                    Hand.Add(card);
                    break;
                case TargetZone.Library:
                    Library.Add(card);
                    break;
                default:
                    throw new Exception("Player.Add - Card: Invalid Zone for player add card");
            }
        }
        public void Add(IEffect effect)
        {
            switch (effect.Target.Type)
            {
                case TargetType.Card:
                    ZoneWithCard(effect.Target.Id).Add(effect);
                    break;
                default:
                    if (effect is AddManaToPoolEffect)
                        ManaPool.Add(((AddManaToPoolEffect)effect).Mana);
                    else if (effect is Mulligan)
                    {
                        CombineToLibrary(true, true);
                        DrawCards(Hand.InitialSize, GamePhases.None);
                        if (Hand.LandMulligan())
                            OnAddPendingAction?.Invoke(this, new PendingActionEventArgs() { PendingAction = new MulliganPendingAction() { ActionPlayerId = Id } });
                    }
                    else if (effect is DamageEffect)
                    {
                        ((DamageEffect)effect).Damage.OnApplyDamage += OnApplyDamage;
                        ((DamageEffect)effect).Damage.Process(effect.Target);
                        ((DamageEffect)effect).Damage.OnApplyDamage -= OnApplyDamage;
                    }
                    else
                        ActiveEffects.Add(effect);
                    break;
            }
        }
        public void ApplyDamage(ApplyDamageEventArgs args)
        {
            if (args.Target.Type == TargetType.Player && Id == args.Target.Id)
            {
                Life = Life - args.DamageValue;

            }
            else if (args.Target.Type == TargetType.Card || args.Target.Type == TargetType.Planeswalker)
                Battlefield.FirstOrDefault(args.Target.Id).ApplyDamage(args);// damage only exists in the battlefield
            else
                throw new Exception("Player.ApplyDamage - No valid target for damage");
        }
        private void Apply(IEffect effect)
        {
            if (effect is AddManaToPoolEffect)
                ManaPool.Add(((AddManaToPoolEffect)effect).Mana);
        }
        public CastSpellResponse CastSpell(Guid spellId, List<SelectableAbility> selectedAbilities)
        {
            CastSpellResponse retVal = new CastSpellResponse() { SpellId = spellId };
            Card castingSpell = Hand.Find(spellId);
            if (castingSpell != null)
            {
                if (castingSpell.HasType(CardType.Land))
                {
                    Hand.Remove(spellId);
                    OnAddCardToZone?.Invoke(this, new AddCardToZoneEventArgs() { Card = castingSpell, TargetZone = TargetZone.Battlefield, ZoneOwnerId = this.Id });
                    retVal.Success = true;
                }
                else if (selectedAbilities != null && selectedAbilities.Count > 0)
                {
                    List<Guid> castingMana = new List<Guid>();
                    CastingCost castingCost = new CastingCost();
                    List<ICastingAbility> selectedCastingAbilities = new List<ICastingAbility>();
                    foreach (SelectableAbility ability in selectedAbilities)
                    {
                        ICastingAbility castingAbility = (ICastingAbility)castingSpell.Abilities.FirstOrDefault(o=>o.Id == ability.AbilityId);
                        castingAbility.Target = ability.Target;
                        selectedCastingAbilities.Add(castingAbility);
                        castingCost.ManaCosts.AddRange(castingAbility.CastingCost.ManaCosts);
                        castingCost.XCost+=castingAbility.CastingCost.XCost;
                    }
                    if (Mana_Helper.CanCast(castingCost, castingSpell, ManaPool, ref castingMana))
                    {
                        ManaPool.UseMana(castingMana);
                        Hand.Remove(spellId);
                        OnAddCardToZone?.Invoke(this, new AddCardToZoneEventArgs() { Card = castingSpell, TargetZone = TargetZone.Stack, ZoneOwnerId = this.Id, SelectedCastingAbilities = selectedCastingAbilities });
                        retVal.Success = true;
                    }
                    else
                        retVal.Message = "Insufficient mana in the pool";
                }
                else
                {
                    List<Guid> castingMana = new List<Guid>();
                    if (Mana_Helper.CanCast(castingSpell.CastingCost, castingSpell, ManaPool, ref castingMana))
                    {
                        ManaPool.UseMana(castingMana);
                        Hand.Remove(spellId);
                        OnAddCardToZone?.Invoke(this, new AddCardToZoneEventArgs() { Card = castingSpell, TargetZone = TargetZone.Stack, ZoneOwnerId = this.Id });
                        retVal.Success = true;
                    }
                    else
                        retVal.Message = "Insufficient mana in the pool";
                }
            }
            else
                retVal.Message = "Selected spell is not in hand any longer" ;
            return retVal;
        }
        public bool CheckLoseConditions()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.3. There are several ways to lose the game.
                104.3a A player can concede the game at any time. A player who concedes leaves 
                        the game immediately. That player loses the game.
                104.3b If a player’s life total is 0 or less, that player loses the game the next 
                        time a player would receive priority. (This is a state-based action. See rule 704.)
                104.3c If a player is required to draw more cards than are left in their library, 
                        they draw the remaining cards and then lose the game the next time a player would 
                        receive priority. (This is a state-based action. See rule 704.)
                104.3d If a player has ten or more poison counters, that player loses the game the next 
                        time a player would receive priority. (This is a state-based action. See rule 704.)
                104.3e An effect may state that a player loses the game.
                104.3f If a player would both win and lose the game simultaneously, that player loses the 
                        game.
                104.3g In a multiplayer game between teams, a team loses the game if all players on that 
                        team have lost the game.
                104.3h In a multiplayer game using the limited range of influence option (see rule 801), 
                        an effect that states that a player wins the game instead causes all of that player’s 
                        opponents within the player’s range of influence to lose the game. This may not cause 
                        the game to end.
                104.3i In an Emperor game, a team loses the game if its emperor loses the game. 
                        (See rule 809.5.)
                104.3j In a Commander game, a player that’s been dealt 21 or more combat damage by the same 
                        commander over the course of the game loses the game. (This is a state-based action. 
                        See rule 704. See also rule 903.10.)
                104.3k In a tournament, a player may lose the game as a result of a penalty given by a judge. 
                        See rule 100.6.
             */
            if (Conceded)//104.3a 
                LoseMessage = @"Conceded the game";
            else if (Life <= 0)//104.3b 
                LoseMessage = @"No life remaining.";
            else if (Library.Cards.Count == 0 && FailedDraw)//104.3c 
                LoseMessage = @"Not enough cards in current library to complete the required draw.";
            else if (Counters.FindAll(o=>o is Poison).Count >= 10)//104.3d 
                LoseMessage = @"Poisoned to death (" + Counters.FindAll(o => o is Poison).Count + " counters)";
            else if (ForceLose)//104.3e 
                LoseMessage = @"Lost the game";
            return !string.IsNullOrEmpty(LoseMessage);
        }
        private void CombineToLibrary(bool hand, bool graveyard)
        {
            if (graveyard)
                Graveyard.Remove(TargetZone.Library);
            if (hand)
            {
                Hand.Remove(TargetZone.Library);
            }
            Library.Shuffle();
        }
        public void Discard(int randomCount, Guid cardId)
        {
            if (cardId != null)
                Hand.Discard(Hand.Cards.First(o => o.Id == cardId));
            for (int i = 0; i < randomCount; i++)
                Hand.Discard(true, 0);
        }
        private void Discard(Card card)
        {
            OnAddCardToZone?.Invoke(this, new AddCardToZoneEventArgs() { Card = card, TargetZone = TargetZone.Graveyard, ZoneOwnerId = this.Id });
            Hand.Remove(card.Id);
        }
        public void DrawCards(int drawCount, GamePhases currentPhase)
        {
            int cardDrawCount = drawCount;

            if (currentPhase == GamePhases.Beginning_Draw)
                foreach (IEffect drawEffect in ActiveEffects.FindAll(o => o is DrawExtraCards))
                    cardDrawCount += ((DrawExtraCards)drawEffect).Value;

            List<Card> cardsDrawn = new List<Card>();
            if (cardDrawCount > Library.Cards.Count)
            {
                FailedDraw = true;
                cardsDrawn.AddRange(Library.Draw(Library.Cards.Count, Id));
            }
            else
                cardsDrawn.AddRange(Library.Draw(cardDrawCount, Id));
            
            Hand.Add(cardsDrawn);
        }
        public void EmptyManaPool()
        {
            ManaPool.EmptyManaPool();
        }
        public Card FindCard(Guid cardId)
        {
            Card retVal = Battlefield.FirstOrDefault(cardId);
            if(retVal == null)
                Command.Find(cardId);
            if (retVal == null)
                Library.Find(cardId);
            if (retVal == null)
                Hand.Find(cardId);
            if (retVal == null)
                Graveyard.Find(cardId);
            return retVal;
        }
        public bool HasEffectType(Type effectType)
        {
            return ActiveEffects.FirstOrDefault(o => o.GetType() == effectType) != null;
        }
        public void Remove(Type effectType)
        {
            IEffect removeEffect = ActiveEffects.FirstOrDefault(o => o.GetType() == effectType);
            if (removeEffect != null)
                ActiveEffects.Remove(removeEffect);
        }
        public void ResetPlayer()
        {

            ActiveEffects = new List<IEffect>();
            SkipPhases = new List<GamePhases>();
            Life = 20;
            LoseMessage = @"";
            ManaPool = new ManaPool();
            if (Deck != null)
                SelectDeck(Deck);
            else
                Deck = new Deck();
        }
        public void SelectDeck(Deck deck)
        {
            Deck = deck;
            Library.Add(Deck.CloneCards());
            Library.Shuffle();
        }
        public void UntapPermanents()
        {
            Battlefield.Untap();
        }
        public IZone ZoneWithCard(Guid cardId)
        {
            if (Battlefield.FirstOrDefault(cardId) != null)
                Battlefield.FirstOrDefault(cardId);
            if (Command.Find(cardId) != null)
                Command.Find(cardId);
            if (Library.Find(cardId) != null)
                Library.Find(cardId);
            if (Hand.Find(cardId) != null)
                return Hand;
            if (Graveyard.Find(cardId) != null)
                return Graveyard;
            return null;
        }
        #endregion
    }
}
