using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Death_Ward : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=248
            *  
            *  Regenerate target creature.
            *  
            * Rulings

            *  
            */
        public Death_Ward() : base()
        {
            MultiverseId = 248;
            Name = "Death Ward";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Death Ward");
        }
        public Death_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
