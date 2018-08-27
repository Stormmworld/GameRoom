using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Celestial_Prism : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=5
        *  
        *  {2}, {T}: Add one mana of any color to your mana pool.
        *  
        * Rulings

        *
        */
        public Celestial_Prism() : base()
        {
            MultiverseId = 5;
            Name = "Celestial Prism";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Celestial Prism");
        }
        public Celestial_Prism(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
