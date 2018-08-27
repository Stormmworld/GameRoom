using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Hurloon_Minotaur : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=206
        *  
        *  
        *  
        * Rulings

        *
        */
        public Hurloon_Minotaur() : base()
        {
            MultiverseId = 206;
            Name = "Hurloon Minotaur";
            Set(2, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Minotaur);
            Add(CardType.Creature);

            throw new NotImplementedException("Hurloon Minotaur");
        }
        public Hurloon_Minotaur(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
