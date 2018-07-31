using MTG.ArgumentDefintions;
using MTG.Enumerations;
using MTG.Interfaces;
using System;
using System.Collections.Generic;

namespace MTG.Model.Abilities
{ 
    public class Recover : IAbility
    {
        /*
        * https://mtg.gamepedia.com/Recover
             702.58a Recover is a triggered ability that functions only while the card with recover is 
                    in a player’s graveyard. “Recover [cost]” means “When a creature is put into your 
                    graveyard from the battlefield, you may pay [cost]. If you do, return this card 
                    from your graveyard to your hand. Otherwise, exile this card.”
        */
        #region Variables
        public List<AbilityType> _Types;
        #endregion

        #region Properties
        public EffectTrigger Trigger { get { return EffectTrigger.EntersGraveyard; } }
        public IReadOnlyCollection<AbilityType> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructor
        public Recover()
        {
            _Types = new List<AbilityType>();
            _Types.Add(AbilityType.Triggered);
        }
        #endregion

        #region Methods
        public AbilityProcessedEventArgs Process(AbilityArgs args)
        {
            throw new NotImplementedException("Recover.Process");
        }
        #endregion
    }
}
