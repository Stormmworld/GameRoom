using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Shanodin_Dryads : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=172
        *  
        *  Forestwalk (This creature can't be blocked as long as defending player controls a Forest.)
        *  
        * Rulings

        *
        */
        public Shanodin_Dryads() : base()
        {
            MultiverseId = 172;
            Name = "Shanodin Dryads";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Nymph);
            Add(SubType.Dryad);
            Add(CardType.Creature);

            throw new NotImplementedException("Shanodin Dryads");
        }
        public Shanodin_Dryads(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
