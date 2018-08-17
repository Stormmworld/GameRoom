using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Absorb : IStaticAbility
    {
        /*
         * https://mtg.gamepedia.com/Absorb
            702.63a Absorb is a static ability. “Absorb N” means “If a source would deal 
                    damage to this creature, prevent N of that damage.”
            702.63b Each absorb ability can prevent only N damage from any one source at 
                    any one time. It will apply separately to damage from other sources, 
                    or to damage dealt by the same source at a different time.
            702.63c If an object has multiple instances of absorb, each applies separately.
         */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Absorb()
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
