using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Affinity : IStaticAbility
    {
        /*
        * https://mtg.gamepedia.com/Affinity
        702.40a Affinity is a static ability that functions while the spell with affinity is on
        the stack. “Affinity for [text]” means “This spell costs you {1} less to cast for 
        each [text] you control.”
        702.40b If a spell has multiple instances of affinity, each of them applies.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Affinity()
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
