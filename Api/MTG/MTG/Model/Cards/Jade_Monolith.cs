using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Jade_Monolith : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=23
        *  
        *  {1}: The next time a source of your choice would deal damage to target creature this turn, that source deals that damage to you instead.
        *  
        * Rulings

        *
        */
        public Jade_Monolith() : base()
        {
            MultiverseId = 23;
            Name = "Jade Monolith";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Jade Monolith");
        }
        public Jade_Monolith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
