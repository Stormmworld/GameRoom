using MTG.Enumerations;
using MTG.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Interfaces
{
    public interface ITriggerArgs
    {
        Player ActivePlayer { get; set; }
    }
}
