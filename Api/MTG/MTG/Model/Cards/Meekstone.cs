using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Meekstone : Card
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
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Meekstone");
        }
        public Meekstone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
