using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lifelace : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=163
            *  
            *  Target spell or permanent becomes green. (Mana symbols on that permanent remain unchanged.)
            *  
            * Rulings

            *  
            */
        public Lifelace() : base()
        {
            MultiverseId = 163;
            Name = "Lifelace";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Lifelace");
        }
        public Lifelace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
