using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Ivory_Cup : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=22
        *  
        *  Whenever a player casts a white spell, you may pay {1}. If you do, you gain 1 life.
        *  
        * Rulings

        *
        */
        public Ivory_Cup() : base()
        {
            MultiverseId = 22;
            Name = "Ivory Cup";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Ivory Cup");
        }
        public Ivory_Cup(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
