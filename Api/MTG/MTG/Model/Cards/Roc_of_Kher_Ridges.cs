using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Roc_of_Kher_Ridges : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=218
        *  
        *  Flying
        *  
        * Rulings

        *
        */
        public Roc_of_Kher_Ridges() : base()
        {
            MultiverseId = 218;
            Name = "Roc of Kher Ridges";
            Set(3, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Bird);
            Add(CardType.Creature);

            throw new NotImplementedException("Roc of Kher Ridges");
        }
        public Roc_of_Kher_Ridges(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
