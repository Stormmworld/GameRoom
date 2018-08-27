using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Goblin_King : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=202
        *  
        *  Other Goblin creatures get +1/+1 and have mountainwalk. (They can't be blocked as long as defending player controls a Mountain.)
        *  
        * Rulings
        * 2005-08-01: Goblin King now has the Goblin creature type and its ability has been reworded to affect *other* Goblins. This means that if two Goblin Kings are on the battlefield, each gives the other a bonus.

        *
        */
        public Goblin_King() : base()
        {
            MultiverseId = 202;
            Name = "Goblin King";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Goblin);
            Add(CardType.Creature);

            throw new NotImplementedException("Goblin King");
        }
        public Goblin_King(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
