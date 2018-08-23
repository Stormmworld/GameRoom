using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Ironroot_Treefolk : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=159
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Ironroot_Treefolk() : base()
        {
            MultiverseId = 159;
            Name = "Ironroot Treefolk";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Treefolk);
	Add(Enumerations.CardType.Creature);
	_Power = 3;
		_Toughness = 5;

            throw new NotImplementedException("Ironroot Treefolk");
        }
        public Ironroot_Treefolk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
