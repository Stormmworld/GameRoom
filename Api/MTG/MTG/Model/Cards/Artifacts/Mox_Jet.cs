using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Mox_Jet : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=33
        *  
        *  {T}: Add {B} to your mana pool.
        *  
        * Rulings

        *
        */
        public Mox_Jet() : base()
        {
            MultiverseId = 33;
            Name = "Mox Jet";
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
        }
        public Mox_Jet(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
