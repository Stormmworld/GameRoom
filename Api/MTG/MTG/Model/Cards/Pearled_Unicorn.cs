using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Pearled_Unicorn : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=261
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Pearled_Unicorn() : base()
        {
            MultiverseId = 261;
            Name = "Pearled Unicorn";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Unicorn);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Pearled Unicorn");
        }
        public Pearled_Unicorn(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
