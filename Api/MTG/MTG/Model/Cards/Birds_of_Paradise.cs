using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Birds_of_Paradise : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=142
            *  
            *  Flying
{T}: Add one mana of any color to your mana pool.
            *  
            * Rulings

            *  
            */
        public Birds_of_Paradise() : base()
        {
            MultiverseId = 142;
            Name = "Birds of Paradise";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Bird);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 1;

            throw new NotImplementedException("Birds of Paradise");
        }
        public Birds_of_Paradise(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
