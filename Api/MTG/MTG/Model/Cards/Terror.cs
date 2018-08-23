using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Terror : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=86
            *  
            *  Destroy target nonartifact, nonblack creature. It can't be regenerated.
            *  
            * Rulings

            *  
            */
        public Terror() : base()
        {
            MultiverseId = 86;
            Name = "Terror";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Terror");
        }
        public Terror(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
