using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class PendingDamageEventArgs:EventArgs
    {
        public Damage Damage { get; set; }
    }
}
