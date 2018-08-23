using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class War_Mammoth : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=183
            *  
            *  Trample
            *  
            * Rulings

            *  
            */
        public War_Mammoth() : base()
        {
            MultiverseId = 183;
            Name = "War Mammoth";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Elephant);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 3;

            throw new NotImplementedException("War Mammoth");
        }
        public War_Mammoth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
