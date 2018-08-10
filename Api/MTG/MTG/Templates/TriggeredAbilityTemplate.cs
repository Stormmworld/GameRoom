using MTG.Interfaces;
using MTG.Enumerations;
using System;
using MTG.Model.Objects;

namespace MTG.Templates
{
    public class TriggeredAbilityTemplate : ITriggeredAbility
    {
        /*
        * TriggeredAbilityTemplate
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Card_Blocked; } }
        #endregion

        #region Constructors
        public TriggeredAbilityTemplate()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("TriggeredAbilityTemplate.Process");
        }
        public ITriggeredAbilityArgs GenerateArgs(ITriggeredAbilityArgs triggeredAbilityArgs, Card originCard)
        {
            throw new NotImplementedException("TriggeredAbilityTemplate.GenerateArgs");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}