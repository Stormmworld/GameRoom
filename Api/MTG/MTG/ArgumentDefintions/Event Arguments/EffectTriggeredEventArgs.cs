using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class EffectTriggeredEventArgs: EventArgs
    {
        public IEffect Effect { get; set; }
    }
}
