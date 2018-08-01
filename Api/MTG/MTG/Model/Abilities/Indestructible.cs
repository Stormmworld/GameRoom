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
        public event EventHandler PendingActionTriggered, EffectTriggered;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.CardDestroyed; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Indestructible()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Static);
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
