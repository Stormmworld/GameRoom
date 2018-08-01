using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Annihilator : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Annihilator
            702.85a Annihilator is a triggered ability. “Annihilator N” means “Whenever this creature 
                    attacks, defending player sacrifices N permanents.”
            702.85b If a creature has multiple instances of annihilator, each triggers separately.
         */
        #region Events
        public event EventHandler PendingActionTriggered, EffectTriggered;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.DelcaredAsAttacker; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Annihilator()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Annihilator.Process");
        }
        #endregion
    }
}
