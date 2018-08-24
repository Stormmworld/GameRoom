using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class Tap: IActivatedAbility
    {
        /*
        * Tap
             
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Variables
        #endregion

        #region Properties
        public CastingCost ActivationCost { get; private set; }
        public Guid BoundCardId { get; set; }
        public Guid Id { get; private set; }
        public bool RequiresTap { get; private set; }
        #endregion

        #region Constructors
        private Tap()
        {
            Id = Guid.NewGuid();
            ActivationCost = new CastingCost();
        }
        public Tap(CastingCost activationCost, bool requiresTap)
        {
            ActivationCost = activationCost;
            RequiresTap = requiresTap;
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            throw new NotImplementedException("Tap.Activate");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
