using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Mox_Ruby : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=35
        *  
        *  {T}: Add {R} to your mana pool.
        *  
        * Rulings

        *
        */
        public Mox_Ruby() : base()
        {
            MultiverseId = 35;
            Name = "Mox Ruby";
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Red, 1) }));
        }
        public Mox_Ruby(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
