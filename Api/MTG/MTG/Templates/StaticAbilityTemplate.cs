using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Templates
{
    public class StaticAbilityTemplate: IStaticAbility
    {
        /*
        * StaticAbilityTemplate
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
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
