using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Verduran_Enchantress : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=178
            *  
            *  Whenever you cast an enchantment spell, you may draw a card.
            *  
            * Rulings

            *  
            */
        public Verduran_Enchantress() : base()
        {
            MultiverseId = 178;
            Name = "Verduran Enchantress";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Human);
	Add(Enumerations.SubType.Druid);
	Add(Enumerations.CardType.Creature);
	_Power = 0;
		_Toughness = 2;

            throw new NotImplementedException("Verduran Enchantress");
        }
        public Verduran_Enchantress(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
