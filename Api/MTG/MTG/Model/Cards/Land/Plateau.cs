using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Plateau : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=281
        *  
        *  ({T}: Add {R} or {W} to your mana pool.)
        *  
        * Rulings
        * 2008-10-01: This has the mana abilities associated with both of its basic land types.
        * 2008-10-01: This has basic land types, but it isn't a basic land. Things that affect basic lands don't affect it. Things that affect basic land types do.

        *
        */
        public Plateau() : base()
        {
            MultiverseId = 281;
            Name = "Plateau";
            Add(SubType.Mountain);
            Add(SubType.Plains);
            Add(CardType.Land);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Red, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }));
        }
        public Plateau(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
