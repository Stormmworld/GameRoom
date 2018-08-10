using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions.Event_Arguments
{
    public class CardEventArgs:EventArgs
    {
        public Card Card { get; set; }
    }
}
