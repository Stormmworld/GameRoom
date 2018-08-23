using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{
    public class Defender : IStaticAbility
    {
        /*
        * Defender
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        private Defender()
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
