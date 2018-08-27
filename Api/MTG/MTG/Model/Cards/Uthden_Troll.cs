using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Uthden_Troll : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=228
        *  
        *  {R}: Regenerate Uthden Troll.
        *  
        * Rulings

        *
        */
        public Uthden_Troll() : base()
        {
            MultiverseId = 228;
            Name = "Uthden Troll";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Troll);
            Add(CardType.Creature);

            throw new NotImplementedException("Uthden Troll");
        }
        public Uthden_Troll(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
