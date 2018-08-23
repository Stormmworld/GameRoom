using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Gauntlet_of_Might : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=15
            *  
            *  Red creatures get +1/+1.
Whenever a Mountain is tapped for mana, its controller adds {R} to his or her mana pool (in addition to the mana the land produces).
            *  
            * Rulings
		2004-10-04: Dual lands which have Mountain as one of their types produce an extra red mana when tapped for either color.

            *  
            */
        public Gauntlet_of_Might() : base()
        {
            MultiverseId = 15;
            Name = "Gauntlet of Might";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Gauntlet of Might");
        }
        public Gauntlet_of_Might(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
