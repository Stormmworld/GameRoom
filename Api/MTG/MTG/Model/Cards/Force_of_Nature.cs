using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Force_of_Nature : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=150
        *  
        *  Trample (This creature can deal excess combat damage to defending player or planeswalker while attacking.)
        *  At the beginning of your upkeep, Force of Nature deals 8 damage to you unless you pay {G}{G}{G}{G}.
        *  
        * Rulings
        *
        */
        public Force_of_Nature() : base()
        {
            MultiverseId = 150;
            Name = "Force of Nature";
            Set(8, 8);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Elemental);
            Add(CardType.Creature);

            throw new NotImplementedException("Force of Nature");
        }
        public Force_of_Nature(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
