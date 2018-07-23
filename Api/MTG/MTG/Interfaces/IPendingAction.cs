using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Interfaces
{
    public interface IPendingAction
    {
        int ActionPlayerId { get; set; }
    }
}
