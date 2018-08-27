using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Orcish_Artillery : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=213
        *  
        *  {T}: Orcish Artillery deals 2 damage to target creature or player and 3 damage to you.
        *  
        * Rulings
        * 2004-10-04: You do not take the 3 points of damage if the ability is countered because the target is illegal.

        *
        */
        public Orcish_Artillery() : base()
        {
            MultiverseId = 213;
            Name = "Orcish Artillery";
            Set(1, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Orc);
            Add(SubType.Warrior);
            Add(CardType.Creature);

            throw new NotImplementedException("Orcish Artillery");
        }
        public Orcish_Artillery(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
