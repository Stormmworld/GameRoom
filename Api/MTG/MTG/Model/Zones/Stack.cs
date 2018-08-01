using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;
using MTGModel.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Zones
{
    /*
     *  https://mtg.gamepedia.com/Stack
        405.1. When a spell is cast, the physical card is put on the stack (see rule 601.2a). When an ability is 
                activated or triggers, it goes on top of the stack without any card associated with it (see rules 
                602.2a and 603.3).
        405.2. The stack keeps track of the order that spells and/or abilities were added to it. Each time an 
                object is put on the stack, it’s put on top of all objects already there.
        405.3. If an effect puts two or more objects on the stack at the same time, those controlled by the active 
                player are put on lowest, followed by each other player’s objects in APNAP order (see rule 101.4). 
                If a player controls more than one of these objects, that player chooses their relative order on 
                the stack.
        405.4. Each spell has all the characteristics of the card associated with it. Each activated or triggered 
                ability that’s on the stack has the text of the ability that created it and no other characteristics. 
                The controller of a spell is the person who cast it. The controller of an activated ability is the 
                player who activated it. The controller of a triggered ability is the player who controlled the 
                ability’s source when it triggered, unless it’s a delayed triggered ability. To determine the 
                controller of a delayed triggered ability, see rules 603.7d–f.
        405.5. When all players pass in succession, the top (last-added) spell or ability on the stack resolves. 
                If the stack is empty when all players pass, the current step or phase ends and the next begins.
        405.6. Some things that happen during the game don’t use the stack.
        405.6a Effects don’t go on the stack; they’re the result of spells and abilities resolving. Effects may 
                create delayed triggered abilities, however, and these may go on the stack when they trigger 
                (see rule 603.7).
        405.6b Static abilities continuously generate effects and don’t go on the stack. (See rule 604, “Handling 
                Static Abilities.”) This includes characteristic-defining abilities such as “[This object] is 
                red” (see rule 604.3).
        405.6c Mana abilities resolve immediately. If a mana ability both produces mana and has another effect, 
                the mana is produced and the other effect happens immediately. If a player had priority before a 
                mana ability was activated, that player gets priority after it resolves. (See rule 605, “Mana 
                Abilities.”)
        405.6d Special actions don’t use the stack; they happen immediately. See rule 115, “Special Actions.”
        405.6e Turn-based actions don’t use the stack; they happen automatically when certain steps or phases 
                begin. They’re dealt with before a player would receive priority (see rule 116.3a). Turn-based 
                actions also happen automatically when each step and phase ends; no player receives priority 
                afterward. See rule 703.
        405.6f State-based actions don’t use the stack; they happen automatically when certain conditions are met. 
                See rule 704. They are dealt with before a player would receive priority. See rule 116.5.
        405.6g A player may concede the game at any time. That player leaves the game immediately. See rule 104.3a.
        405.6h If a player leaves a multiplayer game, objects may leave the game, cease to exist, change control,
                or be exiled as a result. These actions happen immediately. See rule 800.4a.
     */
    public class Stack: IZone
    {
        #region Events
        public event EventHandler OnEffectTrigger;
        #endregion

        #region Properties
        public List<StackEntry> Entries { get; set; }
        public IReadOnlyCollection<Card> Cards
        {
            get
            {
                List<Card> retVal = new List<Card>();
                foreach (StackEntry entry in Entries.FindAll(o => o.EntryType == StackEntryType.Spell))
                    retVal.Add(entry.Card);
                return retVal.AsReadOnly();
            }
        }
        #endregion

        #region Constructors
        public Stack()
        {
            Entries = new List<StackEntry>();
        }
        #endregion

        #region Methods
        public void Add(Card card)
        {
            Entries.Add(new StackEntry(Entries.Count + 1, card));
        }
        public void Add(List<Card> cards)
        {
            throw new NotImplementedException("Stack.Add");
        }
        public void Add(Effect effect, Card originCard)
        {
            Entries.Add(new StackEntry(Entries.Count + 1, effect, originCard.ImageUrl));
        }
        public List<Card> CardsWithAbility(Type abilityType)
        {
            throw new NotImplementedException("Stack.CardsWithAbility");
        }
        public void CounterSpell(Card targetSpell, Card counteringSpell)
        {
            if (targetSpell.TriggeredEffects.FirstOrDefault(o => o.Trigger == EffectTrigger.Cast && o.EffectType == EffectTypes.CannotCounter) != null)
                return;
            throw new NotImplementedException("Stack.CounterSpell");
        }
        public List<Card> FilteredCards(Predicate<Card> predicate)
        {
            throw new NotImplementedException("Stack.FilteredCards");
        }
        public static void Process(ActiveGame game)
        {
            while (game.Stack.Entries.Count > 0)
            {
                StackEntry entry = game.Stack.Entries[game.Stack.Entries.Count-1];
                Player controllerPlayer = game.Players.First(o=>o.Id == entry.Card.ControllerId);
                switch (entry.EntryType)
                {
                    case StackEntryType.Effect:
                        break;
                    case StackEntryType.Spell:
                        if (entry.Card.IsPermanant)
                        {
                            controllerPlayer.Battlefield.Add(entry.Card);
                        }
                        break;
                }
                game.Stack.Entries.RemoveAt(game.Stack.Entries.Count - 1);
            }
            throw new NotImplementedException("Stack.Process");
        }
        public void ProcessTriggeredAbilities(EffectTrigger trigger, ITriggerArgs args)
        {
            throw new NotImplementedException("Stack.ProcessTriggeredAbilities");
        }
        public void Remove(Card card, TargetZone targetZone)
        {
            throw new NotImplementedException("Stack.Remove");
        }
        #endregion
    }
}
