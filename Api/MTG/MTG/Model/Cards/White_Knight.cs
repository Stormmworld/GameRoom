using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class White_Knight : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=274
        *  
        *  First strike (This creature deals combat damage before creatures without first strike.)
Protection from black (This creature can't be blocked, targeted, dealt damage, or enchanted by anything black.)
        *  
        * Rulings

        *
        */
        public White_Knight() : base()
        {
            MultiverseId = 274;
            Name = "White Knight";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Human);
            Add(SubType.Knight);
            Add(CardType.Creature);

            throw new NotImplementedException("White Knight");
        }
        public White_Knight(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
