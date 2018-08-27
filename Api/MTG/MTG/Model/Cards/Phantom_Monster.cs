using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Phantom_Monster : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=117
        *  
        *  Flying
        *  
        * Rulings

        *
        */
        public Phantom_Monster() : base()
        {
            MultiverseId = 117;
            Name = "Phantom Monster";
            Set(3, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(SubType.Illusion);
            Add(CardType.Creature);

            throw new NotImplementedException("Phantom Monster");
        }
        public Phantom_Monster(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
