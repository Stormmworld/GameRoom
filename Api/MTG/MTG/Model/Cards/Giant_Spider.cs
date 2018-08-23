using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Giant_Spider : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=154
            *  
            *  Reach (This creature can block creatures with flying.)
            *  
            * Rulings
		2008-04-01: This card now uses the Reach keyword ability to enable the blocking of flying creatures. This works because a creature with flying can only be blocked by creatures with flying or reach.

            *  
            */
        public Giant_Spider() : base()
        {
            MultiverseId = 154;
            Name = "Giant Spider";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Spider);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 4;

            throw new NotImplementedException("Giant Spider");
        }
        public Giant_Spider(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
