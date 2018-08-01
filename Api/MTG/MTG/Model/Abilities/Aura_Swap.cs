using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Aura_Swap : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Aura_swap
            702.64a Aura swap is an activated ability of some Aura cards. “Aura swap [cost]” 
                    means “[Cost]: You may exchange this permanent with an Aura card in your hand.”
            702.64b If either half of the exchange can’t be completed, the ability has no effect.
                Example: You activate the aura swap ability of an Aura. The only Aura card in your 
                        hand can’t enchant the permanent that’s enchanted by the Aura with aura 
                        swap. The ability has no effect.
                Example: You activate the aura swap ability of an Aura that you control but you 
                        don’t own. The ability has no effect.
         */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.IsInBattlefield; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Aura_Swap()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Activated);
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Aura_Swap.Process");
        }
        #endregion
    }
}
