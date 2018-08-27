using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Soul_Net : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=41
        *  
        *  Whenever a creature dies, you may pay {1}. If you do, you gain 1 life.
        *  
        * Rulings
        * 2004-10-04: If animated so it is a creature, it can be triggered off its own destruction.

        *
        */
        public Soul_Net() : base()
        {
            MultiverseId = 41;
            Name = "Soul Net";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Soul Net");
        }
        public Soul_Net(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
