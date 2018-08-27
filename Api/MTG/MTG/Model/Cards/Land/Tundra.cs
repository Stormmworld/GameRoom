using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Tundra : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=286
        *  
        *  ({T}: Add {W} or {U} to your mana pool.)
        *  
        * Rulings
        * 2008-10-01: This has the mana abilities associated with both of its basic land types.
        * 2008-10-01: This has basic land types, but it isn't a basic land. Things that affect basic lands don't affect it. Things that affect basic land types do.

        *
        */
        public Tundra() : base()
        {
            MultiverseId = 286;
            Name = "Tundra";
            Add(SubType.Plains);
            Add(SubType.Island);
            Add(CardType.Land);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 1) }));
        }
        public Tundra(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
