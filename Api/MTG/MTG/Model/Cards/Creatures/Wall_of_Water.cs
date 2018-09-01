using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Wall_of_Water : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=138
        *  
        *  Defender (This creature can't attack.)
        *  {U}: Wall of Water gets +1/+0 until end of turn.
        *  
        * Rulings
        *
        */
        public Wall_of_Water() : base()
        {
            MultiverseId = 138;
            Name = "Wall of Water";
            Set(0, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Wall);
            Add(CardType.Creature);
            Add(new Defender());
            Add(new CounterGenerator(false, new List<IManaCost>() { new ManaCost(new Mana(Color.Blue, 1)) }, new PlusXPlusY(1, 0) { RemoveAtEndOfTurn = true }));
        }
        public Wall_of_Water(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
