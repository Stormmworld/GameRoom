using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Serra_Angel : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=270
            *  
            *  Flying (This creature can't be blocked except by creatures with flying or reach.)
Vigilance (Attacking doesn't cause this creature to tap.)
            *  
            * Rulings

            *  
            */
        public Serra_Angel() : base()
        {
            MultiverseId = 270;
            Name = "Serra Angel";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Angel);
	Add(Enumerations.CardType.Creature);
	_Power = 4;
		_Toughness = 4;

            throw new NotImplementedException("Serra Angel");
        }
        public Serra_Angel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
