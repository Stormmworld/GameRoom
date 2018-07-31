using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Surge : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Surge
             702.116a Surge is a static ability that functions while the spell with surge is 
                    on the stack. “Surge [cost]” means “You may pay [cost] rather than pay 
                    this spell’s mana cost as you cast this spell if you or one of your 
                    teammates has cast another spell this turn.” Paying a spell’s surge cost 
                    follows the rules for paying alternative costs in rules 601.2b and 601.2f–h.
        */
        #region Properties
        public EffectTrigger Trigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Surge.Process");
        }
        #endregion
    }
}
