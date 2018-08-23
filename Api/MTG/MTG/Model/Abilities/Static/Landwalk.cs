using MTG.Enumerations;
using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{
    public class Landwalk: IStaticAbility
    {
        /*
        * Landwalk
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public SubType LandType { get; private set; }
        #endregion

        #region Constructors
        private Landwalk()
        {
            Id = Guid.NewGuid();
        }
        public Landwalk(SubType landType)
        {
            LandType = landType;
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
