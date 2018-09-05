using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class PreventDamageEffect: Effect
    {
        #region Properties
        public AmountType AmountType { get; private set; }
        public int Value { get; private set; }
        #endregion

        #region Constructors
        public PreventDamageEffect(ITarget target, AmountType amountType) : base(target)
        {
            AmountType = amountType;
        }
        public PreventDamageEffect(ITarget target, AmountType amountType, int value) : this(target, amountType)
        {
            Value = value;
        }
        #endregion

        #region Methods
        #endregion
    }
}
