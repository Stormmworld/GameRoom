using MTG.Enumerations;
using MTG.Model.Abilities._Base;
using System;

namespace MTG.Model.Abilities.Static
{
    public class ConvertSubType: StaticAbility
    {
        #region Properties
        public SubType OriginalSubType { get; private set; }
        public SubType NewSubType { get; private set; }
        #endregion

        #region Constructors
        public ConvertSubType(SubType originalSubType, SubType newSubType)
        {
            OriginalSubType = originalSubType;
            NewSubType = newSubType;
        }
        public ConvertSubType(SubType originalSubType, SubType newSubType, Guid boundCardId):this(originalSubType, newSubType)
        {
            BoundCardId = boundCardId;
        }
        #endregion
    }
}
