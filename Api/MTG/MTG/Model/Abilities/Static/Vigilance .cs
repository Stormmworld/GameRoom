using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{
    public class Vigilance: IStaticAbility
    {
        /*
        * https://mtg.gamepedia.com/Vigilance
            702.20a Vigilance is a static ability that modifies the rules for the declare attackers step.
            702.20b Attacking doesn’t cause creatures with vigilance to tap. (See rule 508, “Declare Attackers Step.”)
            702.20c Multiple instances of vigilance on the same creature are redundant.    
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Vigilance()
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
