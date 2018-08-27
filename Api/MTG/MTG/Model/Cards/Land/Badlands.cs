using MTG.Enumerations;
using MTG.Model.Abilities.Activated;
using MTG.Model.Cards._Base;
using MTG.Model.Mana_Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Badlands : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=279
        *  
        *  ({T}: Add {B} or {R} to your mana pool.)
        *  
        * Rulings
        * 2004-10-04: Land type changing effects that change a dual land's land type will remove the old land types completely. Text-changing effects that just change one of the two land types will leave the other type unaffected.
        * 2004-10-04: This card is a Mountain and a Swamp even while in the graveyard, library, or any other zone.
        * 2008-10-01: This has the mana abilities associated with both of its basic land types.
        * 2008-10-01: This has basic land types, but it isn't a basic land. Things that affect basic lands don't affect it. Things that affect basic land types do.
        *
        */
        public Badlands() : base()
        {
            MultiverseId = 279;
            Name = "Badlands";
            Add(SubType.Swamp);
            Add(SubType.Mountain);
            Add(CardType.Land);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Red, 1) }));
        }
        public Badlands(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
