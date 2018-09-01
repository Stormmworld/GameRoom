using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Model.Counters;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Wall_of_Fire : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=229
        *  
        *  Defender (This creature can't attack.)
        *  {R}: Wall of Fire gets +1/+0 until end of turn.
        *  
        * Rulings

        *
        */
        public Wall_of_Fire() : base()
        {
            MultiverseId = 229;
            Name = "Wall of Fire";
            Set(0, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Wall);
            Add(CardType.Creature);
            Add(new Defender());
            Add(new CounterGenerator(false,new List<IManaCost>() { new ManaCost(new Mana(Color.Red, 1)) }, new PlusXPlusY(1, 0) { RemoveAtEndOfTurn = true }));
        }
        public Wall_of_Fire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
