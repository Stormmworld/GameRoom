using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Thoughtlace : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=130
            *  
            *  Target spell or permanent becomes blue. (Mana symbols on that permanent remain unchanged.)
            *  
            * Rulings

            *  
            */
        public Thoughtlace() : base()
        {
            MultiverseId = 130;
            Name = "Thoughtlace";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Thoughtlace");
        }
        public Thoughtlace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
