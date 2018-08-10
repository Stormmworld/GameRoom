using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class EffectTriggerEventArgs: EventArgs
    {
        #region Properties
        public ITriggerArgs Args { get; set; }
        public EffectTrigger Trigger { get; set; }
        #endregion

        #region Constructors
        public EffectTriggerEventArgs()
        {
        }
        #endregion
    }
}
