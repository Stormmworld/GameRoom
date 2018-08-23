using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Counterspell : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=102
            *  
            *  Counter target spell.
            *  
            * Rulings

            *  
            */
        public Counterspell() : base()
        {
            MultiverseId = 102;
            Name = "Counterspell";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Counterspell");
        }
        public Counterspell(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
