using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Mox_Pearl : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=34
        *  
        *  {T}: Add {W} to your mana pool.
        *  
        * Rulings

        *
        */
        public Mox_Pearl() : base()
        {
            MultiverseId = 34;
            Name = "Mox Pearl";
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }));
        }
        public Mox_Pearl(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
