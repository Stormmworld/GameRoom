

using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class ExtraManaEffect : Effect
    {
        #region Properties
        public Color GeneratedColor { get; private set; }
        #endregion

        #region Constructors
        public ExtraManaEffect(ITarget target, Color generatedColor) : base(target)
        {
            GeneratedColor = generatedColor;
            Assign(target);
        }
        #endregion
    }
}
