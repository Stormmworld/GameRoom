using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class DamageEffect : Effect
    {
        #region Properties
        public IDamage Damage { get; private set; }
        #endregion

        #region Constructors
        public DamageEffect(ITarget target, IDamage damage) :  base(target)
        {
            Assign(target);
            Damage = damage;
        }
        #endregion
    }
}