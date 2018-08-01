using MTG.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Interfaces
{
    public interface ITriggerArgs
    {
        EffectTrigger Trigger { get; set; }
    }
}
