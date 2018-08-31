using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;

namespace MTG.Model.Data_Objects
{
    public class TargetCardRequirements : ITargetCardRequirements
    {
        #region Properties
        public Color HasColor { get; internal set; }
        public CardType HasType { get; internal set; }
        public SubType HasSubType { get; internal set; }
        public SuperType HasSuperType { get; internal set; }
        public TargetZone InZone { get; internal set; }
        public bool Tapped { get; internal set; }
        #endregion

        #region Constructors
        public TargetCardRequirements()
        {
        }
        #endregion

        #region Methods
        public void Assign(Color color)
        {
            HasColor = color;
        }
        public void Assign(CardType type)
        {
            HasType = type;
        }
        public void Assign(SubType subType)
        {
            HasSubType = subType;
        }
        public void Assign(SuperType superType)
        {
            HasSuperType = superType;
        }
        public void Assign(TargetZone zone)
        {
            InZone = zone;
        }
        #endregion
    }
}
