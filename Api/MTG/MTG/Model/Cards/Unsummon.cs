using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Unsummon : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=134
            *  
            *  Return target creature to its owner's hand.
            *  
            * Rulings

            *  
            */
        public Unsummon() : base()
        {
            MultiverseId = 134;
            Name = "Unsummon";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Unsummon");
        }
        public Unsummon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
