using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Frozen_Shade : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=65
        *  
        *  {B}: Frozen Shade gets +1/+1 until end of turn.
        *  
        * Rulings
        *
        */
        public Frozen_Shade() : base()
        {
            MultiverseId = 65;
            Name = "Frozen Shade";
            Set(0, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Shade);
            Add(CardType.Creature);
            Add(new CounterGenerator(false, new List<IManaCost>() { new ManaCost(new Mana(Color.Black, 1)) }, new PlusXPlusY(1, 1) { RemoveAtEndOfTurn = true }));
        }
        public Frozen_Shade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
