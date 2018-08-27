using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Disrupting_Scepter : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=13
        *  
        *  {3}, {T}: Target player discards a card. Activate this ability only during your turn.
        *  
        * Rulings
        * 2004-10-04: You can use it on yourself.

        *
        */
        public Disrupting_Scepter() : base()
        {
            MultiverseId = 13;
            Name = "Disrupting Scepter";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Disrupting Scepter");
        }
        public Disrupting_Scepter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
