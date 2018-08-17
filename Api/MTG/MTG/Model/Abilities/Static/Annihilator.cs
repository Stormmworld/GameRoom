using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Annihilator : IStaticAbility
    {
        /*
         * https://mtg.gamepedia.com/Annihilator
            702.85a Annihilator is a triggered ability. “Annihilator N” means “Whenever this creature 
                    attacks, defending player sacrifices N permanents.”
            702.85b If a creature has multiple instances of annihilator, each triggers separately.
         */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Annihilator()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
