using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Fog : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=149
            *  
            *  Prevent all combat damage that would be dealt this turn.
            *  
            * Rulings

            *  
            */
        public Fog() : base()
        {
            MultiverseId = 149;
            Name = "Fog";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Fog");
        }
        public Fog(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
