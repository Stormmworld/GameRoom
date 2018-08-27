using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Swamp : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=277
        *  
        *  
        *  
        * Rulings

        *
        */
        public Swamp() : base()
        {
            MultiverseId = 277;
            Name = "Swamp";
            Add(SubType.Swamp);
            Add(CardType.Land);
            Add(SuperType.Basic);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
        }
        public Swamp(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
