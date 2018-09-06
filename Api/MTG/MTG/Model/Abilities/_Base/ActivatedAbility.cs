using MTG.Enumerations;
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
        public List<GamePhase> PhaseRestriction { get; internal set; }
        #endregion

        #region Properties
        public bool YourTurnRestriction { get; internal set; }
        public bool RequiresTap { get; private set; }
        #endregion

        #region Constructors
        internal ActivatedAbility(bool requiresTap) : base()
        {
            _ActivationCost = new List<IManaCost>();
            PhaseRestriction = new List<GamePhase>();
            RequiresTap = requiresTap;
        }
        internal ActivatedAbility(bool requiresTap, GamePhase removeAtPhase) : this(requiresTap)
        {
            RemoveAtPhase = removeAtPhase;
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
