using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Volcanic_Island : Permanent
    {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=585
        *  
        *  ({T}: Add {U} or {B} to your mana pool.)
        *  
        * Rulings
        * 2008-10-01: This has the mana abilities associated with both of its basic land types.
        * 2008-10-01: This has basic land types, but it isn't a basic land. Things that affect basic lands don't affect it. Things that affect basic land types do.
        *
        */
        public Volcanic_Island() : base()
        {
            MultiverseId = 287;
            Name = "Underground Sea";
            Add(SubType.Island);
            Add(SubType.Swamp);
            Add(CardType.Land);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
        }
        public Volcanic_Island(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
