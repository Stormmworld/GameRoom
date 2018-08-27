using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Sunglasses_of_Urza : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=42
        *  
        *  You may spend white mana as though it were red mana.
        *  
        * Rulings

        *
        */
        public Sunglasses_of_Urza() : base()
        {
            MultiverseId = 42;
            Name = "Sunglasses of Urza";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Sunglasses of Urza");
        }
        public Sunglasses_of_Urza(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
