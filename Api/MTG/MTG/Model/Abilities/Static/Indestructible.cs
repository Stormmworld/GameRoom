using MTG.Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Indestructible : IStaticAbility
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
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Indestructible()
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
