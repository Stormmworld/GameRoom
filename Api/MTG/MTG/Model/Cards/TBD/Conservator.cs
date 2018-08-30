using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Conservator : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=8
        *  
        *  {3}, {T}: Prevent the next 2 damage that would be dealt to you this turn.
        *  
        * Rulings

        *
        */
        public Conservator() : base()
        {
            MultiverseId = 8;
            Name = "Conservator";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Conservator");
        }
        public Conservator(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
