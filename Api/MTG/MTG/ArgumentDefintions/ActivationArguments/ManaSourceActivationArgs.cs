using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.ActivationArguments
{
    public class ManaSourceActivationArgs: IActivationArgs
    {
        #region Properties
        public Guid ActivatingCardId { get; internal set; }
        public Guid ActivatingPlayerId { get; set; } 
        public int CardTypeCount { get; set; }
        public int ManaMultiplier { get; set; }
        #endregion
    }
}
