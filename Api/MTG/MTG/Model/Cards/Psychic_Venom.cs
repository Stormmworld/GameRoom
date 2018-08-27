using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Psychic_Venom : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=123
        *  
        *  Enchant land
Whenever enchanted land becomes tapped, Psychic Venom deals 2 damage to that land's controller.
        *  
        * Rulings
        * 2004-10-04: Whenever the land is tapped for any reason, the ability triggers.

        *
        */
        public Psychic_Venom() :  base(new TargetCardRequirements() { })
        {
            MultiverseId = 123;
            Name = "Psychic Venom";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Aura);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Psychic Venom");
        }
        public Psychic_Venom(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
