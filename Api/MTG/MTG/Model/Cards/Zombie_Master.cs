using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Zombie_Master : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=93
        *  
        *  Other Zombie creatures have swampwalk. (They can't be blocked as long as defending player controls a Swamp.)
Other Zombies have "{B}: Regenerate this permanent."
        *  
        * Rulings

        *
        */
        public Zombie_Master() : base()
        {
            MultiverseId = 93;
            Name = "Zombie Master";
            Set(2, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Zombie);
            Add(CardType.Creature);

            throw new NotImplementedException("Zombie Master");
        }
        public Zombie_Master(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
