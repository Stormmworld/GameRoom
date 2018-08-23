using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Frozen_Shade : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=65
            *  
            *  {B}: Frozen Shade gets +1/+1 until end of turn.
            *  
            * Rulings

            *  
            */
        public Frozen_Shade() : base()
        {
            MultiverseId = 65;
            Name = "Frozen Shade";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Shade);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 1;

            throw new NotImplementedException("Frozen Shade");
        }
        public Frozen_Shade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
