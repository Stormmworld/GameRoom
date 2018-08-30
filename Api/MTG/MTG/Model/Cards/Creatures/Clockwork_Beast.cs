using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Counters;
using MTG.Interfaces.Data_Interfaces;
using System.Linq;

namespace MTG.Model.Cards
{
    public class Clockwork_Beast : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=7
        *  
        *  Clockwork Beast enters the battlefield with seven +1/+0 counters on it.
        *    At end of combat, if Clockwork Beast attacked or blocked this combat, remove a +1/+0 counter from it.
        *    {X}, {T}: Put up to X +1/+0 counters on Clockwork Beast. This ability can't cause the total number of +1/+0 counters on Clockwork Beast to be greater than seven. Activate this ability only during your upkeep.
        *  
        * Rulings
        * 2004-10-04: Loses a counter even if it is affected by a Fog-like effect which prevents it from dealing damage.
        * 2004-10-04: Can attack or block even if it has no counters.
        * 2007-09-16: This is a change from the most recent wording. Now, if some other spell or ability causes +1/+0 counters to be put on Clockwork Beast, it can wind up with more than seven such counters on it.
        * 2007-09-16: If Clockwork Beast has seven or fewer +1/+0 counters on it when its last ability resolves, it can wind up a maximum of seven such counters on it. If it has seven or more +1/+0 counters on it, the ability will have no effect.
        * 2007-09-16: Clockwork Beast's last ability resolves, you can choose to put fewer than X +1/+0 counters on it.
        *
        */
        #region Constructors
        public Clockwork_Beast() : base()
        {
            MultiverseId = 7;
            Name = "Clockwork Beast";
            Set(0, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 6)));
            Add(SubType.Beast);
            Add(CardType.Artifact);
            Add(CardType.Creature);
            Add(new CounterGenerator(false, new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Colorless, true))}), new PlusXPlusY(1, 0) { OwningCardId = Id }));
            Add(new Abilities.Triggered.CounterRemoval(EffectTrigger.Phases_CombatPhase_EndStep, new PlusXPlusY(1, 0) { OwningCardId = Id }, new List<CardAction>() { CardAction.Attacker, CardAction.Blocker }));
        }
        public Clockwork_Beast(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
        #endregion

        #region Methods
        public override void Add(ICounter counter)
        {
            if (Counters.Where(o => o.OwningCardId == Id).ToList().Count < 7)
                base.Add(counter);
        }
        #endregion
    }
}
