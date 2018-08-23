using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class The_Hive : Card
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
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("The Hive");
        }
        public The_Hive(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
