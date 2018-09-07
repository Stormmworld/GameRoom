using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;
using MTG.Model.Counters;

namespace MTG.Model.Cards
{
    public class Fungusaur : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=151
        *  
        *  Whenever Fungusaur is dealt damage, put a +1/+1 counter on it.
        *  
        * Rulings
        * 2004-10-04: If more than one creature damages it at one time, it only gets one counter.
        *
        */
        public Fungusaur() : base()
        {
            MultiverseId = 151;
            Name = "Fungusaur";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Fungus);
            Add(SubType.Dinosaur);
            Add(CardType.Creature);
            Add(new CounterGenerator(EffectTrigger.Card_DealtDamage, new TargetRequirements(TargetScope.Self, TargetType.None), new PlusXPlusY(1, 1)));
        }
        public Fungusaur(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}