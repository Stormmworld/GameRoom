using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Counters;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Granite_Gargoyle : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=203
        *  
        *  Flying
        *  {R}: Granite Gargoyle gets +0/+1 until end of turn.
        *  
        * Rulings
        *
        */
        public Granite_Gargoyle() : base()
        {
            MultiverseId = 203;
            Name = "Granite Gargoyle";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Gargoyle);
            Add(CardType.Creature);
            Add(new CounterGenerator(false, new List<IManaCost>() { new ManaCost(new Mana(Color.Red, 1)) }, new PlusXPlusY(1, 1) { RemoveAtEndOfTurn = true }));
        }
        public Granite_Gargoyle(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}