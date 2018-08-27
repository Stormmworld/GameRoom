using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Verduran_Enchantress : Creature
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
            Set(0, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Human);
            Add(SubType.Druid);
            Add(CardType.Creature);

            throw new NotImplementedException("Verduran Enchantress");
        }
        public Verduran_Enchantress(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
