using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class PlusXPlusY: IActivatedAbility
    {
        /*
        * PlusXPlusY
             
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
        public int X { get; private set; }
        public int Y { get; private set; }
        #endregion

        #region Constructors
        private PlusXPlusY()
        {
            Id = Guid.NewGuid();
            ActivationCost = new CastingCost();
        }
        public PlusXPlusY(CastingCost activationCost, int x, int y)
        {
            ActivationCost = activationCost;
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            throw new NotImplementedException("PlusXPlusY.Activate");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
