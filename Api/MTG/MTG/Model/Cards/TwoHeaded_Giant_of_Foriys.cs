using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class TwoHeaded_Giant_of_Foriys : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=227
        *  
        *  Trample
Two-Headed Giant of Foriys can block an additional creature each combat.
        *  
        * Rulings

        *
        */
        public TwoHeaded_Giant_of_Foriys() : base()
        {
            MultiverseId = 227;
            Name = "Two-Headed Giant of Foriys";
            Set(4, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Giant);
            Add(CardType.Creature);

            throw new NotImplementedException("Two-Headed Giant of Foriys");
        }
        public TwoHeaded_Giant_of_Foriys(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
