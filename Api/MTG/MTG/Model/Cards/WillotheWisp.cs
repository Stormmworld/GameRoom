using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class WillotheWisp : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=91
            *  
            *  Flying (This creature can't be blocked except by creatures with flying or reach.)
{B}: Regenerate Will-o'-the-Wisp. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
            *  
            * Rulings

            *  
            */
        public WillotheWisp() : base()
        {
            MultiverseId = 91;
            Name = "Will-o'-the-Wisp";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Spirit);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 1;

            throw new NotImplementedException("Will-o'-the-Wisp");
        }
        public WillotheWisp(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}