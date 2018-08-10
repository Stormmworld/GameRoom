using MTG.Interfaces;
using System;

namespace MTG.ArgumentDefintions.ActivationArguments
{
    public class ManaSourceActivationArgs: IActivationArgs
    {
        public Guid ActivatingPlayerId { get; set; } 
        public int CardTypeCount { get; set; }
        public int ManaMultiplier { get; set; }
    }
}
