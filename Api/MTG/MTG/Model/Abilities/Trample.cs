using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{
    public class Trample : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Trample
             
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Card_DamageCreature; } }
        public AbilityType Type { get { return AbilityType.Triggered; } }
        #endregion

        #region Constructors
        public Trample()
        {

        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Trample.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
