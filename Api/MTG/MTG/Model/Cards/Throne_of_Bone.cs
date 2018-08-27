using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Throne_of_Bone : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=44
        *  
        *  Whenever a player casts a black spell, you may pay {1}. If you do, you gain 1 life.
        *  
        * Rulings

        *
        */
        public Throne_of_Bone() : base()
        {
            MultiverseId = 44;
            Name = "Throne of Bone";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Throne of Bone");
        }
        public Throne_of_Bone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
