using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Shivan_Dragon : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=222
        *  
        *  Flying (This creature can't be blocked except by creatures with flying or reach.)
{R}: Shivan Dragon gets +1/+0 until end of turn.
        *  
        * Rulings

        *
        */
        public Shivan_Dragon() : base()
        {
            MultiverseId = 222;
            Name = "Shivan Dragon";
            Set(5, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Dragon);
            Add(CardType.Creature);

            throw new NotImplementedException("Shivan Dragon");
        }
        public Shivan_Dragon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
