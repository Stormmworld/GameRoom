using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Evil_Presence : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=63
            *  
            *  Enchant land
Enchanted land is a Swamp.
            *  
            * Rulings
		2009-10-01: The enchanted land loses its existing land types and any abilities printed on it. It now has the land type Swamp and has the ability "{T}: Add {B} to your mana pool." Evil Presence doesn't change the enchanted land's name or whether it's legendary, basic, or snow.

            *  
            */
        public Evil_Presence() : base()
        {
            MultiverseId = 63;
            Name = "Evil Presence";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Evil Presence");
        }
        public Evil_Presence(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
