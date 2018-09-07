using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Activated;

namespace MTG.Model.Cards
{
    public class Sol_Ring : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=40
        *  
        *  {T}: Add {C}{C} to your mana pool.
        *  
        * Rulings
        *
        */
        public Sol_Ring() : base()
        {
            MultiverseId = 40;
            Name = "Sol Ring";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Colorless, 1) }));
        }
        public Sol_Ring(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}