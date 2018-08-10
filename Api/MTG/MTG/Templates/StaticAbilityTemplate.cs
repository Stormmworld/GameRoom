using MTG.Interfaces;
using System;

namespace MTG.Templates
{
    public class StaticAbilityTemplate: IStaticAbility
    {
        /*
        * StaticAbilityTemplate
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public StaticAbilityTemplate()
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
