using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Meekstone : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=31
        *  
        *  Creatures with power 3 or greater don't untap during their controllers' untap steps.
        *  
        * Rulings

        *
        */
        public Meekstone() : base()
        {
            MultiverseId = 31;
            Name = "Meekstone";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Meekstone");
        }
        public Meekstone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
