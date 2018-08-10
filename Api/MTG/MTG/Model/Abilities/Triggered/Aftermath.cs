using MTG.Interfaces;
using MTG.Enumerations;
using System;
using MTG.Model.Objects;

namespace MTG.Model.Abilities.Triggered
{ 
    public class Aftermath : ITriggeredAbility
    {
        /*
         * https://mtg.gamepedia.com/Aftermath
            702.126a Aftermath is an ability found on some split cards (see rule 708, “Split Cards”). 
                    It represents three static abilities. “Aftermath” means “You may cast this half of 
                    this split card from your graveyard,” “This half of this split card can’t be cast 
                    from any zone other than a graveyard,” and “If this spell was cast from a graveyard, 
                    exile it instead of putting it anywhere else any time it would leave the stack.”
         */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get { return EffectTrigger.Card_InGraveyard; } }
        #endregion

        #region Constructors
        public Aftermath()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public ITriggeredAbilityArgs GenerateArgs(ITriggeredAbilityArgs triggeredAbilityArgs, Card originCard)
        {
            throw new NotImplementedException("Afflict.GenerateArgs");
        }
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("Aftermath.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
