using MTG.Enumerations;
using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Activated
{
    public class ConvertToCreatureActivated:ActivatedAbility
    {
        #region Properties
        public int Power { get; private set; }
        public int Toughness { get; private set; }
        #endregion

        #region Constructors
        public ConvertToCreatureActivated(bool requiresTap, int power, int toughness, GamePhase removeAtPhase) : base(requiresTap, removeAtPhase)
        {

        }
        public ConvertToCreatureActivated(bool requiresTap, List<IManaCost> activationCost, int power, int toughness, GamePhase removeAtPhase) : this(requiresTap, power, toughness, removeAtPhase)
        {
            Add(activationCost);
        }
        #endregion

        #region Methods
        public void Process(ITarget target)
        {
            throw new NotImplementedException("ConvertToCreatureActivated.Process");
        }
        #endregion
    }
}
