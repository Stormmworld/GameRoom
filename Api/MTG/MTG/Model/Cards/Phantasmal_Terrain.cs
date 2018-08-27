using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Phantasmal_Terrain : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=116
        *  
        *  Enchant land
As Phantasmal Terrain enters the battlefield, choose a basic land type.
Enchanted land is the chosen type.
        *  
        * Rulings
        * 2006-10-15: Will not add or remove Snow Supertype to or from a land.

        *
        */
        public Phantasmal_Terrain() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 116;
            Name = "Phantasmal Terrain";
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Phantasmal Terrain");
        }
        public Phantasmal_Terrain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
