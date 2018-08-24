using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Amplify : IStaticAbility
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
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Amplify()
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
