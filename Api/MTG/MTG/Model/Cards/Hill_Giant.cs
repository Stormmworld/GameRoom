using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Hill_Giant : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=205
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Hill_Giant() : base()
        {
            MultiverseId = 205;
            Name = "Hill Giant";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Giant);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 3;

            throw new NotImplementedException("Hill Giant");
        }
        public Hill_Giant(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
