using MTG.Interfaces.Data_Interfaces;

namespace MTG.Interfaces.Effect_Interfaces
{
    public interface IEffect
    {
        #region Properties
        ITarget Target { get; }
        int XValue { get; }
        #endregion

        #region Methods
        void AssignXValue(int xValue);
        #endregion
    }
}
