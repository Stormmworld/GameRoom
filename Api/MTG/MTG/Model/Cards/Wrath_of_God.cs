using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Wrath_of_God : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=276
        *  
        *  Destroy all creatures. They can't be regenerated.
        *  
        * Rulings

        *
        */
        public Wrath_of_God() : base()
        {
            MultiverseId = 276;
            Name = "Wrath of God";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Wrath of God");
        }
        public Wrath_of_God(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
