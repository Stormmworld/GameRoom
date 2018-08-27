using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Mountain : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=290
        *  
        *  
        *  
        * Rulings

        *
        */
        public Mountain() : base()
        {
            MultiverseId = 290;
            Name = "Mountain";
            Add(SubType.Mountain);
            Add(CardType.Land);
            Add(SuperType.Basic);

            throw new NotImplementedException("Mountain");
        }
        public Mountain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
