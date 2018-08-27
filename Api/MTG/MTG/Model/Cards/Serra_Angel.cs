using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Serra_Angel : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=270
        *  
        *  Flying (This creature can't be blocked except by creatures with flying or reach.)
Vigilance (Attacking doesn't cause this creature to tap.)
        *  
        * Rulings

        *
        */
        public Serra_Angel() : base()
        {
            MultiverseId = 270;
            Name = "Serra Angel";
            Set(4, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Angel);
            Add(CardType.Creature);

            throw new NotImplementedException("Serra Angel");
        }
        public Serra_Angel(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
