﻿using MTG.Model.Objects;
using System;

namespace MTG.ArgumentDefintions
{
    public class CardEventArgs:EventArgs
    {
        public Card Card { get; set; }
    }
}