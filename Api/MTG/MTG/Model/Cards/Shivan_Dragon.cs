using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Shivan_Dragon : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=222
            *  
            *  Flying (This creature can't be blocked except by creatures with flying or reach.)
{R}: Shivan Dragon gets +1/+0 until end of turn.
            *  
            * Rulings

            *  
            */
        public Shivan_Dragon() : base()
        {
            MultiverseId = 222;
            Name = "Shivan Dragon";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Dragon);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 5;

            throw new NotImplementedException("Shivan Dragon");
        }
        public Shivan_Dragon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
