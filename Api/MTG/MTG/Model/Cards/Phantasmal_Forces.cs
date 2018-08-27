using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Phantasmal_Forces : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=115
        *  
        *  Flying
At the beginning of your upkeep, sacrifice Phantasmal Forces unless you pay {U}.
        *  
        * Rulings

        *
        */
        public Phantasmal_Forces() : base()
        {
            MultiverseId = 115;
            Name = "Phantasmal Forces";
            Set(4, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Illusion);
            Add(CardType.Creature);

            throw new NotImplementedException("Phantasmal Forces");
        }
        public Phantasmal_Forces(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
