using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Tunnel : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=226
            *  
            *  Destroy target Wall. It can't be regenerated.
            *  
            * Rulings

            *  
            */
        public Tunnel() : base()
        {
            MultiverseId = 226;
            Name = "Tunnel";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Tunnel");
        }
        public Tunnel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
