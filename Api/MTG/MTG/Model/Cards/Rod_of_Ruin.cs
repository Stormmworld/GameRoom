using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Rod_of_Ruin : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=39
        *  
        *  {3}, {T}: Rod of Ruin deals 1 damage to target creature or player.
        *  
        * Rulings

        *
        */
        public Rod_of_Ruin() : base()
        {
            MultiverseId = 39;
            Name = "Rod of Ruin";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Rod of Ruin");
        }
        public Rod_of_Ruin(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
