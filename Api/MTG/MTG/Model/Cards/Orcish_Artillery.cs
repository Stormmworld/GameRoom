using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Orcish_Artillery : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=213
            *  
            *  {T}: Orcish Artillery deals 2 damage to target creature or player and 3 damage to you.
            *  
            * Rulings
		2004-10-04: You do not take the 3 points of damage if the ability is countered because the target is illegal.

            *  
            */
        public Orcish_Artillery() : base()
        {
            MultiverseId = 213;
            Name = "Orcish Artillery";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Orc);
	Add(Enumerations.SubType.Warrior);
	Add(Enumerations.CardType.Creature);
	_Power = 1;
		_Toughness = 3;

            throw new NotImplementedException("Orcish Artillery");
        }
        public Orcish_Artillery(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
