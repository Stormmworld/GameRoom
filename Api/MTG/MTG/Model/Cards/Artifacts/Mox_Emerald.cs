using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Mox_Emerald : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=32
        *  
        *  {T}: Add {G} to your mana pool.
        *  
        * Rulings

        *
        */
        public Mox_Emerald() : base()
        {
            MultiverseId = 32;
            Name = "Mox Emerald";
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Green, 1) }));
        }
        public Mox_Emerald(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
