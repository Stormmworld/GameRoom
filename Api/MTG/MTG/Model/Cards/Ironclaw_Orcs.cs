using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Ironclaw_Orcs : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=207
        *  
        *  Ironclaw Orcs can't block creatures with power 2 or greater.
        *  
        * Rulings

        *
        */
        public Ironclaw_Orcs() : base()
        {
            MultiverseId = 207;
            Name = "Ironclaw Orcs";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Orc);
            Add(CardType.Creature);

            throw new NotImplementedException("Ironclaw Orcs");
        }
        public Ironclaw_Orcs(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
