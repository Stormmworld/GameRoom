using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions
{
    public class PendingDamageEventArgs:EventArgs
    {
        public Damage Damage { get; set; }
    }
}
