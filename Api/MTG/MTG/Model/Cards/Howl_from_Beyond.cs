using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Howl_from_Beyond : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=67
            *  
            *  Target creature gets +X/+0 until end of turn.
            *  
            * Rulings

            *  
            */
        public Howl_from_Beyond() : base()
        {
            MultiverseId = 67;
            Name = "Howl from Beyond";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Howl from Beyond");
        }
        public Howl_from_Beyond(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
