using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class Regeneration: IActivatedAbility
    {
        /*
        * Regeneration
             
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
        private Regeneration()
        {
            Id = Guid.NewGuid();
            ActivationCost = new CastingCost();
        }
        public Regeneration(CastingCost activationCost) :this()
        {
            ActivationCost = activationCost;
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            throw new NotImplementedException("Regeneration.Activate");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
