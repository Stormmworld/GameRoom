using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Bayou : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=280
        *  
        *  ({T}: Add {B} or {G} to your mana pool.)
        *  
        * Rulings
        * 2008-10-01: This has the mana abilities associated with both of its basic land types.
        * 2008-10-01: This has basic land types, but it isn't a basic land. Things that affect basic lands don't affect it. Things that affect basic land types do.

        *
        */
        public Bayou() : base()
        {
            MultiverseId = 280;
            Name = "Bayou";
            Add(SubType.Swamp);
            Add(SubType.Forest);
            Add(CardType.Land);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Green, 1) }));
        }
        public Bayou(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
