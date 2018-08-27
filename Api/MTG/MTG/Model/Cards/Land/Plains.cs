using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Plains : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=294
        *  
        *  
        *  
        * Rulings

        *
        */
        public Plains() : base()
        {
            MultiverseId = 294;
            Name = "Plains";
            Add(SubType.Plains);
            Add(CardType.Land);
            Add(SuperType.Basic);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }));
        }
        public Plains(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
