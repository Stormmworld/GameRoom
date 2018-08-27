using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Ironroot_Treefolk : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=159
        *  
        *  
        *  
        * Rulings

        *
        */
        public Ironroot_Treefolk() : base()
        {
            MultiverseId = 159;
            Name = "Ironroot Treefolk";
            Set(3, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Treefolk);
            Add(CardType.Creature);

            throw new NotImplementedException("Ironroot Treefolk");
        }
        public Ironroot_Treefolk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
