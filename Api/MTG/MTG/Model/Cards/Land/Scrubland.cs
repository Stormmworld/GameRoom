using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Scrubland : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=283
        *  
        *  ({T}: Add {W} or {B} to your mana pool.)
        *  
        * Rulings
        * 2008-10-01: This has the mana abilities associated with both of its basic land types.
        * 2008-10-01: This has basic land types, but it isn't a basic land. Things that affect basic lands don't affect it. Things that affect basic land types do.

        *
        */
        public Scrubland() : base()
        {
            MultiverseId = 283;
            Name = "Scrubland";
            Add(SubType.Plains);
            Add(SubType.Swamp);
            Add(CardType.Land);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
        }
        public Scrubland(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
