using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Earth_Elemental : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=192
        *  
        *  
        *  
        * Rulings

        *
        */
        public Earth_Elemental() : base()
        {
            MultiverseId = 192;
            Name = "Earth Elemental";
            Set(4, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Elemental);
            Add(CardType.Creature);

            throw new NotImplementedException("Earth Elemental");
        }
        public Earth_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
