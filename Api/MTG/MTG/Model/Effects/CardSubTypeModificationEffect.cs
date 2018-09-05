using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class CardSubTypeModificationEffect: Effect
    {
        #region Properties
        public bool ReplaceOtherTypes { get; private set; }
        public SubType NewSubType { get; private set; }
        #endregion

        #region Constructors
        public CardSubTypeModificationEffect(ITarget target, SubType newSubType, bool replaceOtherTypes) : base(target)
        {
            Assign(target);
            NewSubType  = newSubType;
            ReplaceOtherTypes = replaceOtherTypes;
        }
        #endregion
    }
}
