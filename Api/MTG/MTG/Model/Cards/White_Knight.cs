using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class White_Knight : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=274
            *  
            *  First strike (This creature deals combat damage before creatures without first strike.)
Protection from black (This creature can't be blocked, targeted, dealt damage, or enchanted by anything black.)
            *  
            * Rulings

            *  
            */
        public White_Knight() : base()
        {
            MultiverseId = 274;
            Name = "White Knight";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Knight);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("White Knight");
        }
        public White_Knight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
