using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Bodyguard : IStaticAbility
    {
        /*
        10/4/2004	If a creature is blocked but Trample damage is still done to a player, this damage can’t be 
                    redirected to the Bodyguard because the Bodyguard only takes damage from unblocked creatures.
        10/4/2004	Damage goes to the Bodyguard as long as he is untapped. This works even if he is blocking.
        10/4/2004	If you have multiple Veteran Bodyguards, you can decide which one receives the redirected 
                    damage each time damage would be dealt to you.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Bodyguard()
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
