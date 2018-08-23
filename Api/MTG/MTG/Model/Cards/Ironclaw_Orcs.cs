using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Ironclaw_Orcs : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=207
            *  
            *  Ironclaw Orcs can't block creatures with power 2 or greater.
            *  
            * Rulings

            *  
            */
        public Ironclaw_Orcs() : base()
        {
            MultiverseId = 207;
            Name = "Ironclaw Orcs";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Orc);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Ironclaw Orcs");
        }
        public Ironclaw_Orcs(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
