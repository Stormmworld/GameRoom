using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Jayemdae_Tome : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=25
        *  
        *  {4}, {T}: Draw a card.
        *  
        * Rulings

        *
        */
        public Jayemdae_Tome() : base()
        {
            MultiverseId = 25;
            Name = "Jayemdae Tome";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Jayemdae Tome");
        }
        public Jayemdae_Tome(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
