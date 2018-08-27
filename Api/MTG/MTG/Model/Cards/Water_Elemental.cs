using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Water_Elemental : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=139
        *  
        *  
        *  
        * Rulings

        *
        */
        public Water_Elemental() : base()
        {
            MultiverseId = 139;
            Name = "Water Elemental";
            Set(5, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Elemental);
            Add(CardType.Creature);

            throw new NotImplementedException("Water Elemental");
        }
        public Water_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
