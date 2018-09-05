using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Model.Counters;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Cards
{
    public class Dragon_Whelp : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=189
        *  
        *  Flying
        *  {R}: Dragon Whelp gets +1/+0 until end of turn. If this ability has been activated four or more times this turn, sacrifice Dragon Whelp at the beginning of the next end step.
        *  
        * Rulings
        * 2009-10-01: The first three times Dragon Whelp's ability is activated in a turn will do nothing other than give it +1/+0 until end of turn. Any subsequent activations will also cause its delayed triggered ability to trigger. That means if you activate Dragon Whelp's ability five times, for example, two different delayed triggered abilities will trigger at the beginning of the next end step and cause you to sacrifice Dragon Whelp.
        * 2009-10-01: If the fourth (or more) time Dragon Whelp's ability is activated during the same turn happens to be during that turn's end step, the delayed triggered ability won't trigger until the beginning of the next turn's end step. You'll have to sacrifice Dragon Whelp at that time.

        *
        */
        public Dragon_Whelp() : base()
        {
            MultiverseId = 189;
            Name = "Dragon Whelp";
            Set(2, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Dragon);
            Add(CardType.Creature);
            Add(new CounterGenerator(false,new List<IManaCost>() { new ManaCost(new Mana(Color.Red, 1))}, new PlusXPlusY(1, 0) { RemoveAtEndOfTurn = true }));
        }
        public Dragon_Whelp(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
