using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions
{
    public class EffectTriggerEventArgs: EventArgs
    {
        public ITriggerArgs Args { get; set; }
        public EffectTrigger Trigger { get; set; }
    }
}
