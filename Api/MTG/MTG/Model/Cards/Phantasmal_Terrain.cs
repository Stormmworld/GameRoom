using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Phantasmal_Terrain : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=116
            *  
            *  Enchant land
As Phantasmal Terrain enters the battlefield, choose a basic land type.
Enchanted land is the chosen type.
            *  
            * Rulings
		2006-10-15: Will not add or remove Snow Supertype to or from a land.

            *  
            */
        public Phantasmal_Terrain() : base()
        {
            MultiverseId = 116;
            Name = "Phantasmal Terrain";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Phantasmal Terrain");
        }
        public Phantasmal_Terrain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
