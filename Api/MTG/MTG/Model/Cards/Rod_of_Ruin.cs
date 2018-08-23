using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Rod_of_Ruin : Card
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
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Rod of Ruin");
        }
        public Rod_of_Ruin(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
