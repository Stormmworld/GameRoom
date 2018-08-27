using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Mox_Sapphire : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=36
        *  
        *  {T}: Add {U} to your mana pool.
        *  
        * Rulings

        *
        */
        public Mox_Sapphire() : base()
        {
            MultiverseId = 36;
            Name = "Mox Sapphire";
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 1) }));
        }
        public Mox_Sapphire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
