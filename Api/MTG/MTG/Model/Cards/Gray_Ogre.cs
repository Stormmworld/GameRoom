using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Gray_Ogre : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=204
            *  
            *  
            *  
            * Rulings

            *  
            */
        public Gray_Ogre() : base()
        {
            MultiverseId = 204;
            Name = "Gray Ogre";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.SubType.Ogre);
	Add(Enumerations.CardType.Creature);
	_Power = 2;
		_Toughness = 2;

            throw new NotImplementedException("Gray Ogre");
        }
        public Gray_Ogre(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
