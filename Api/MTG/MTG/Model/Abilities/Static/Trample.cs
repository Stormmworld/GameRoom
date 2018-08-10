using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;
using MTG.Model.Objects;

namespace MTG.Model.Abilities.Static
{
    public class Trample : IStaticAbility
    {
        /*
        * https://mtg.gamepedia.com/Trample
             702.19. Trample
                702.19a Trample is a static ability that modifies the rules for assigning an attacking creature’s combat damage. 
                        The ability has no effect when a creature with trample is blocking or is dealing noncombat damage. 
                        (See rule 510, “Combat Damage Step.”)
                702.19b The controller of an attacking creature with trample first assigns damage to the creature(s) blocking 
                        it. Once all those blocking creatures are assigned lethal damage, any remaining damage is assigned as 
                        its controller chooses among those blocking creatures and the player or planeswalker the creature is 
                        attacking. When checking for assigned lethal damage, take into account damage already marked on the 
                        creature and damage from other creatures that’s being assigned during the same combat damage step, 
                        but not any abilities or effects that might change the amount of damage that’s actually dealt. The 
                        attacking creature’s controller need not assign lethal damage to all those blocking creatures but in 
                        that case can’t assign any damage to the player or planeswalker it’s attacking.
                    Example: A 2/2 creature that can block an additional creature blocks two attackers: a 1/1 with no abilities 
                        and a 3/3 with trample. The active player could assign 1 damage from the first attacker and 1 damage 
                        from the second to the blocking creature, and 2 damage to the defending player from the creature with 
                        trample.
                    Example: A 6/6 green creature with trample is blocked by a 2/2 creature with protection from green. The 
                        attacking creature’s controller must assign at least 2 damage to the blocker, even though that damage will 
                        be prevented by the blocker’s protection ability. The attacking creature’s controller can divide the rest 
                        of the damage as they choose between the blocking creature and the defending player.
                702.19c If an attacking creature with trample is blocked, but there are no creatures blocking it when damage is 
                        assigned, all its damage is assigned to the player or planeswalker it’s attacking.
                702.19d If a creature with trample is attacking a planeswalker, none of its combat damage can be assigned to the 
                        defending player, even if that planeswalker has been removed from combat or the damage the attacking creature 
                        could assign is greater than the planeswalker’s loyalty.
                702.19e Multiple instances of trample on the same creature are redundant.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Trample()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
