using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Deathlace : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=57
            *  
            *  Target spell or permanent becomes black. (Mana symbols on that permanent remain unchanged.)
            *  
            * Rulings

            *  
            */
        public Deathlace() : base()
        {
            MultiverseId = 57;
            Name = "Deathlace";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Deathlace");
        }
        public Deathlace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
