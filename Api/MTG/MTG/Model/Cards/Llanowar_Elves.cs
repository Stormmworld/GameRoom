using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Llanowar_Elves : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=166
        *  
        *  {T}: Add {G} to your mana pool.
        *  
        * Rulings

        *
        */
        public Llanowar_Elves() : base()
        {
            MultiverseId = 166;
            Name = "Llanowar Elves";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Elf);
            Add(SubType.Druid);
            Add(CardType.Creature);

            throw new NotImplementedException("Llanowar Elves");
        }
        public Llanowar_Elves(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
