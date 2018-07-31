using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities
{ 
    public class Totem_Armor : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Totem_armor
             702.88a Totem armor is a static ability that appears on some Auras. “Totem armor” 
                    means “If enchanted permanent would be destroyed, instead remove all damage 
                    marked on it and destroy this Aura.”
        */
        #region Properties
        public EffectTrigger Trigger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Totem_Armor.Process");
        }
        #endregion
    }
}
