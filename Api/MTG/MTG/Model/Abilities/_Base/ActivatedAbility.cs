using MTG.Interfaces.Ability_Interfaces;
using MTG.Interfaces.Argument_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities._Base
{
    public class ActivatedAbility : Ability, IActivatedAbility
    {
        #region Variables
        private List<IManaCost> _ActivationCost;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IManaCost> ActivationCost { get { return _ActivationCost.AsReadOnly(); } }
        #endregion

        #region Properties
        public bool RequiresTap { get; private set; }
        #endregion

        #region Constructors
        internal ActivatedAbility(bool requiresTap) : base()
        {
            _ActivationCost = new List<IManaCost>();
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
        public virtual void Add(List<IManaCost> activationCost)
        {
            _ActivationCost.AddRange(activationCost);
        }
        #endregion
    }
}
