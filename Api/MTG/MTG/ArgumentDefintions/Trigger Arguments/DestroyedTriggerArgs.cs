﻿using MTG.Interfaces;
using MTG.Model;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions.Trigger_Arguments
{
    public class DestroyedTriggerArgs : ITriggerArgs
    {
        #region Properties
        public Player ActivePlayer { get; set; }
        public Card ActiveCard { get; set; }
        #endregion
    }
}