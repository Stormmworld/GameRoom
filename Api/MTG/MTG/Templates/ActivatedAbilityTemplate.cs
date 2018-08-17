using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
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
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Variables
        #endregion

        #region Properties
        public CastingCost ActivationCost { get; private set; }
        public Guid Id { get; private set; }
        public bool RequiresTap { get; private set; }
        #endregion

        #region Constructors
        private ActivatedAbilityTemplate()
        {
            Id = Guid.NewGuid();
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
