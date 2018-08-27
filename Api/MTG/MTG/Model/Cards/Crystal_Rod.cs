using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Crystal_Rod : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=10
        *  
        *  Whenever a player casts a blue spell, you may pay {1}. If you do, you gain 1 life.
        *  
        * Rulings

        *
        */
        public Crystal_Rod() : base()
        {
            MultiverseId = 10;
            Name = "Crystal Rod";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Crystal Rod");
        }
        public Crystal_Rod(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
