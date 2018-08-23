using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sedge_Troll : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=220
            *  
            *  Sedge Troll gets +1/+1 as long as you control a Swamp.
{B}: Regenerate Sedge Troll.
            *  
            * Rulings

            *  
            */
        public Sedge_Troll() : base()
        {
            MultiverseId = 220;
            Name = "Sedge Troll";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Troll);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Sedge Troll");
        }
        public Sedge_Troll(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
