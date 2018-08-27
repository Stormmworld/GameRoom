using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;
using MTG.Model.Counters;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Bad_Moon : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=49
        *  
        *  Black creatures get +1/+1.
        *  
        * Rulings

        *
        */
        public Bad_Moon() : base()
        {
            MultiverseId = 49;
            Name = "Bad Moon";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Enchantment);
            Add(new CounterGenerator(EffectTrigger.Card_EntersBattleField,new TargetRequirements(TargetScope.All, new List<TargetType>() { TargetType.Creature }, new TargetCardRequirements() {HasColors= Color.Black }), new PlusXPlusY(1,1) ));
        }
        public Bad_Moon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
