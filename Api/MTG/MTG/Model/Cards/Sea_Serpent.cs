using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Sea_Serpent : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=124
            *  
            *  Sea Serpent can't attack unless defending player controls an Island.
When you control no Islands, sacrifice Sea Serpent.
            *  
            * Rulings

            *  
            */
        public Sea_Serpent() : base()
        {
            MultiverseId = 124;
            Name = "Sea Serpent";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Serpent);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 5;

            throw new NotImplementedException("Sea Serpent");
        }
        public Sea_Serpent(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
