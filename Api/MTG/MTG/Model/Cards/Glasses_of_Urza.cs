using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Glasses_of_Urza : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=16
        *  
        *  {T}: Look at target player's hand.
        *  
        * Rulings

        *
        */
        public Glasses_of_Urza() : base()
        {
            MultiverseId = 16;
            Name = "Glasses of Urza";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Glasses of Urza");
        }
        public Glasses_of_Urza(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
