using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Island : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=292
        *  
        *  
        *  
        * Rulings

        *
        */
        public Island() : base()
        {
            MultiverseId = 292;
            Name = "Island";
            Add(SubType.Island);
            Add(CardType.Land);
            Add(SuperType.Basic);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 1) }));
        }
        public Island(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
