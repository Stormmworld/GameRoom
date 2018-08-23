using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class Untap: IActivatedAbility
    {
        /*
        * Untap
             
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
        private Untap()
        {
            Id = Guid.NewGuid();
            ActivationCost = new CastingCost();
        }
        public Untap(CastingCost activationCost, bool requiresTap)
        {
            ActivationCost = activationCost;
            RequiresTap = requiresTap;
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            throw new NotImplementedException("Untap.Activate");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
