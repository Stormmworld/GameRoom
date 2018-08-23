using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Black_Knight : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=50
            *  
            *  First strike (This creature deals combat damage before creatures without first strike.)
Protection from white (This creature can't be blocked, targeted, dealt damage, or enchanted by anything white.)
            *  
            * Rulings

            *  
            */
        public Black_Knight() : base()
        {
            MultiverseId = 50;
            Name = "Black Knight";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Knight);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Black Knight");
        }
        public Black_Knight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
