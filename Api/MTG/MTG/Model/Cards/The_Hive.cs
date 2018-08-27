using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class The_Hive : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=43
        *  
        *  {5}, {T}: Create a 1/1 colorless Insect artifact creature token with flying named Wasp. (It can't be blocked except by creatures with flying or reach.)
        *  
        * Rulings

        *
        */
        public The_Hive() : base()
        {
            MultiverseId = 43;
            Name = "The Hive";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 5)));
            Add(CardType.Artifact);

            throw new NotImplementedException("The Hive");
        }
        public The_Hive(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
