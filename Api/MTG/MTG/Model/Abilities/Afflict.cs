using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Afflict : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Afflict
            702.129a Afflict is a triggered ability. “Afflict N” means “Whenever this 
                    creature becomes blocked, defending player loses N life.”
            702.129b If a creature has multiple instances of afflict, each triggers separately.
        */
        #region Events
        public event EventHandler PendingActionTriggered, EffectTriggered;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.IsBlocked; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Afflict()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Afflict.Process");
        }
        #endregion
    }
}
