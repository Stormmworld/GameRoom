using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Affinity : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Affinity
        702.40a Affinity is a static ability that functions while the spell with affinity is on
        the stack. “Affinity for [text]” means “This spell costs you {1} less to cast for 
        each [text] you control.”
        702.40b If a spell has multiple instances of affinity, each of them applies.
        */
        #region Events
        public event EventHandler PendingActionTriggered, EffectTriggered;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Cast; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Affinity()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Static);
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Affinity.Process");
        }
        #endregion
    }
}
