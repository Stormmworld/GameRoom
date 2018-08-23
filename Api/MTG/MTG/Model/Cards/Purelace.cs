using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Purelace : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=263
            *  
            *  Target spell or permanent becomes white. (Mana symbols on that permanent remain unchanged.)
            *  
            * Rulings

            *  
            */
        public Purelace() : base()
        {
            MultiverseId = 263;
            Name = "Purelace";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Purelace");
        }
        public Purelace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
