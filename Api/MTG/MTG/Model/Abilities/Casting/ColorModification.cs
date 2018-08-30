using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Casting
{
    public class ColorModification:CastingAbility
    {
        #region Properties
        public bool ReplaceExistingColor { get; set; }
        public Color NewColor { get; set; }
        #endregion

        #region Constructors
        public ColorModification(ICastingCost castingCost, ITargetRequirements targetRequirements, Color newColor, bool replaceExistingcolor ,  bool isAddOn) : base(castingCost, targetRequirements, isAddOn)
        {
            NewColor = newColor;
            ReplaceExistingColor = replaceExistingcolor;
        }
        #endregion
    }
}
