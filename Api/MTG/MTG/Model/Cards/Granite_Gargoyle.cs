using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Granite_Gargoyle : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=203
            *  
            *  Flying
{R}: Granite Gargoyle gets +0/+1 until end of turn.
            *  
            * Rulings

            *  
            */
        public Granite_Gargoyle() : base()
        {
            MultiverseId = 203;
            Name = "Granite Gargoyle";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Gargoyle);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Granite Gargoyle");
        }
        public Granite_Gargoyle(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
