using MTG.Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Templates
{
    public class ActivatedAbilityTemplate: IActivatedAbility
    {
        /*
        * ActivatedAbilityTemplate
             
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        #endregion

        #region Properties
        public CastingCost ActivationCost { get; private set; }
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        private ActivatedAbilityTemplate()
        {
            ActivationCost = new CastingCost();
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            throw new NotImplementedException("ActivatedAbilityTemplate.Activate");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
