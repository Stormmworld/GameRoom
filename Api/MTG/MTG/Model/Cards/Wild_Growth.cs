using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wild_Growth : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=185
            *  
            *  Enchant land
Whenever enchanted land is tapped for mana, its controller adds {G} to his or her mana pool (in addition to the mana the land produces).
            *  
            * Rulings
		2004-10-04: The additional mana is not an ability of the land and is not something the land can produce.

            *  
            */
        public Wild_Growth() : base()
        {
            MultiverseId = 185;
            Name = "Wild Growth";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Wild Growth");
        }
        public Wild_Growth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
