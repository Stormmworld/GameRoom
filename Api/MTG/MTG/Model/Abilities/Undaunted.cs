using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Undaunted : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Undaunted
            702.124a Undaunted is a static ability that functions while the spell with undaunted is on the stack. 
                    Undaunted means “This spell costs {1} less to cast for each opponent you have.”
            702.124b Players who have left the game are not counted when determining how many opponents you have.
            702.124c If a spell has multiple instances of undaunted, each of them applies.
        */
        #region Properties
        public EffectTrigger Trigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Undaunted.Process");
        }
        #endregion
    }
}
