using System;

namespace MTG.Interfaces
{
    public interface ICardEventArgs
    {
        #region Properties
        Guid CardId { get; set; }
        Guid ControllerId { get; set; }
        #endregion

        #region Methods
        string ToString();
        #endregion
    }
}
