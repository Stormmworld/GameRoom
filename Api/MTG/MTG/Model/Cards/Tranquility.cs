using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Tranquility : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=176
        *  
        *  Destroy all enchantments.
        *  
        * Rulings

        *
        */
        public Tranquility() : base()
        {
            MultiverseId = 176;
            Name = "Tranquility";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Tranquility");
        }
        public Tranquility(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
