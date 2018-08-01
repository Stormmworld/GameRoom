using MTG.Interfaces;
using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Amplify : IAbility
    {
        /*
         * https://mtg.gamepedia.com/Amplify
            702.37a Amplify is a static ability. “Amplify N” means “As this object enters the battlefield, 
                    reveal any number of cards from your hand that share a creature type with it. 
                    This permanent enters the battlefield with N +1/+1 counters on it for each card 
                    revealed this way. You can’t reveal this card or any other cards that are entering 
                    the battlefield at the same time as this card.”
            702.37b If a creature has multiple instances of amplify, each one works separately.
         */
        #region Events
        public event EventHandler PendingActionTriggered, EffectTriggered;
        #endregion

        #region Variables
        private List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.EntersBattleField; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Amplify()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Static);
        }
        #endregion

        #region Methods
        public void Process(AbilityArgs args)
        {
            throw new NotImplementedException("Amplify.Process");
        }
        #endregion
    }
}
