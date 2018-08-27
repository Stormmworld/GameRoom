using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Scathe_Zombies : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=81
        *  
        *  
        *  
        * Rulings

        *
        */
        public Scathe_Zombies() : base()
        {
            MultiverseId = 81;
            Name = "Scathe Zombies";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Zombie);
            Add(CardType.Creature);

            throw new NotImplementedException("Scathe Zombies");
        }
        public Scathe_Zombies(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
