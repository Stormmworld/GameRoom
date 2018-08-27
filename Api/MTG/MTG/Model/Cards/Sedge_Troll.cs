using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Sedge_Troll : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=220
        *  
        *  Sedge Troll gets +1/+1 as long as you control a Swamp.
{B}: Regenerate Sedge Troll.
        *  
        * Rulings

        *
        */
        public Sedge_Troll() : base()
        {
            MultiverseId = 220;
            Name = "Sedge Troll";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Troll);
            Add(CardType.Creature);

            throw new NotImplementedException("Sedge Troll");
        }
        public Sedge_Troll(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
