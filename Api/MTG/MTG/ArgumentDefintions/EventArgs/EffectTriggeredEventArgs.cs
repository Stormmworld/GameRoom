using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions
{
    public class EffectTriggeredEventArgs: EventArgs
    {
        public IEffect Effect { get; set; }
    }
}
