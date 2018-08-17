using MTG.Interfaces;
using MTG.Enumerations;
using System;
using MTG.Interfaces.Ability_Interfaces;

namespace MTG.Model.Abilities.Triggered
{ 
    public class Afflict : ITriggeredAbility
    {
        /*
        * https://mtg.gamepedia.com/Afflict
            702.129a Afflict is a triggered ability. “Afflict N” means “Whenever this 
                    creature becomes blocked, defending player loses N life.”
            702.129b If a creature has multiple instances of afflict, each triggers separately.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Card_Blocked; } }
        #endregion

        #region Constructors
        public Afflict()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("Afflict.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
