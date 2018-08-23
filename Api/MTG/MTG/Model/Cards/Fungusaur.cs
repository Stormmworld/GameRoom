using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Fungusaur : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=151
            *  
            *  Whenever Fungusaur is dealt damage, put a +1/+1 counter on it.
            *  
            * Rulings
		2004-10-04: If more than one creature damages it at one time, it only gets one counter.

            *  
            */
        public Fungusaur() : base()
        {
            MultiverseId = 151;
            Name = "Fungusaur";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Fungus);
	Add(Enumerations.SubType.Dinosaur);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Fungusaur");
        }
        public Fungusaur(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
