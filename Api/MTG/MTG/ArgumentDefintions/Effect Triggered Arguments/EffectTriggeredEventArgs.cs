using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.Effect_Triggered_Arguments
{
    public class EffectTriggeredEventArgs : EventArgs, IEffectTriggeredArgs
    {
        #region Properties
        public IEffect Effect { get; private set; }
        #endregion

        #region Constructors
        public EffectTriggeredEventArgs(IEffect effect)
        {
            Effect = effect;
        }
        #endregion
    }
}
