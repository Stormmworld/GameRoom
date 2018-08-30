using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Cards
{
    public class Celestial_Prism : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=5
        *  
        *  {2}, {T}: Add one mana of any color to your mana pool.
        *  
        * Rulings
        *
        */
        public Celestial_Prism() : base()
        {
            MultiverseId = 5;
            Name = "Celestial Prism";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 1) }, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 2)) })));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 1) }, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 2)) })));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Green, 1) }, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 2)) })));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Red, 1) }, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 2)) })));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 1) }, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, 2)) })));
        }
        public Celestial_Prism(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
