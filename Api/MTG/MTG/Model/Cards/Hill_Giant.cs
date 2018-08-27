using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Hill_Giant : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=205
        *  
        *  
        *  
        * Rulings

        *
        */
        public Hill_Giant() : base()
        {
            MultiverseId = 205;
            Name = "Hill Giant";
            Set(3, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Giant);
            Add(CardType.Creature);

            throw new NotImplementedException("Hill Giant");
        }
        public Hill_Giant(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
