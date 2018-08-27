using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Monss_Goblin_Raiders : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=212
        *  
        *  
        *  
        * Rulings

        *
        */
        public Monss_Goblin_Raiders() : base()
        {
            MultiverseId = 212;
            Name = "Mons's Goblin Raiders";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Goblin);
            Add(CardType.Creature);

            throw new NotImplementedException("Mons's Goblin Raiders");
        }
        public Monss_Goblin_Raiders(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
