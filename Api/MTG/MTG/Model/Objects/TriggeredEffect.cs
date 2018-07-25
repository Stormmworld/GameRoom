using MTG.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Model.Objects
{
    public class TriggeredEffect : Effect
    {
        #region Properties
        public EffectTrigger Trigger { get; set; }
        #endregion
    }
}
