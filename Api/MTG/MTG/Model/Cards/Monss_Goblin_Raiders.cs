using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Monss_Goblin_Raiders : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=212
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Monss_Goblin_Raiders() : base()
        {
            MultiverseId = 212;
            Name = "Mons's Goblin Raiders";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Goblin);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 1;

            throw new NotImplementedException("Mons's Goblin Raiders");
        }
        public Monss_Goblin_Raiders(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
