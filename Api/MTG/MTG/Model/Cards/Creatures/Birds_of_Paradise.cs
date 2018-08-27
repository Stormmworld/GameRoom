using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Birds_of_Paradise : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=142
        *  
        *  Flying
{T}: Add one mana of any color to your mana pool.
        *  
        * Rulings

        *
        */
        public Birds_of_Paradise() : base()
        {
            MultiverseId = 142;
            Name = "Birds of Paradise";
            Set(0, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Bird);
            Add(CardType.Creature);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Green, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Red, 1) }));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }));
        }
        public Birds_of_Paradise(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
