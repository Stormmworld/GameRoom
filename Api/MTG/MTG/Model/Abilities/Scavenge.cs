using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Scavenge : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Scavenge
             702.96a Scavenge is an activated ability that functions only while the card with scavenge 
                    is in a graveyard. “Scavenge [cost]” means “[Cost], Exile this card from your 
                    graveyard: Put a number of +1/+1 counters equal to the power of the card you exiled 
                    on target creature. Activate this ability only any time you could cast a sorcery.”
        */
        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.IsInGraveyard; } }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Scavenge.Process");
        }
        #endregion
    }
}
