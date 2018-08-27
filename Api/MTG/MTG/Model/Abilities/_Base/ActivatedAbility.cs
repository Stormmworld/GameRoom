using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Mana_Objects;
using System;

namespace MTG.Model.Abilities._Base
{
    public class ActivatedAbility : Ability, IActivatedAbility
    {
        #region Properties
        public ICastingCost ActivationCost { get; internal set; }
        public bool RequiresTap { get; private set; }
        #endregion

        #region Constructors
        internal ActivatedAbility(bool requiresTap) : base()
        {
            ActivationCost = new CastingCost();
            RequiresTap = requiresTap;
        }
        internal ActivatedAbility(bool requiresTap, bool removeAtEndOfTurn) : this(requiresTap)
        {
            RemoveAtEndOfTurn = removeAtEndOfTurn;
        }
        #endregion

        #region Methods
        public virtual bool Activate(IActivatedAbilityArguments args)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
