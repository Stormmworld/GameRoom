using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Bodyguard : IAbility
    {
        /*
        10/4/2004	If a creature is blocked but Trample damage is still done to a player, this damage can’t be 
                    redirected to the Bodyguard because the Bodyguard only takes damage from unblocked creatures.
        10/4/2004	Damage goes to the Bodyguard as long as he is untapped. This works even if he is blocking.
        10/4/2004	If you have multiple Veteran Bodyguards, you can decide which one receives the redirected 
                    damage each time damage would be dealt to you.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.None; } }
        public AbilityType Type { get { return AbilityType.Static; } }
        #endregion

        #region Constructors
        public Bodyguard()
        {

        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Bodyguard.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
