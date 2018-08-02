using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Indestructible : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Indestructible
            702.12a Indestructible is a static ability.
            702.12b A permanent with indestructible can’t be destroyed. Such permanents aren’t 
                    destroyed by lethal damage, and they ignore the state-based action that 
                    checks for lethal damage (see rule 704.5g).
            702.12c Multiple instances of indestructible on the same permanent are redundant.
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.Card_Destroyed; } }
        public AbilityType Type { get { return AbilityType.Static; } }
        #endregion

        #region Constructors
        public Indestructible()
        {

        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            args.OriginCard.CanBeDestroyed = false;
        }
        #endregion
    }
}
