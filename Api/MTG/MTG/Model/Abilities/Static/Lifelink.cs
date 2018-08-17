using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using System;

namespace MTG.Model.Abilities.Static
{ 
    public class Lifelink : IStaticAbility
    {
        /*
                * https://mtg.gamepedia.com/Lifelink
                    702.15a Lifelink is a static ability.
                    702.15b Damage dealt by a source with lifelink causes that source’s controller, or its 
                            owner if it has no controller, to gain that much life (in addition to any other 
                            results that damage causes). See rule 119.3.
                    702.15c If a permanent leaves the battlefield before an effect causes it to deal damage, 
                            its last known information is used to determine whether it had lifelink.
                    702.15d The lifelink rules function no matter what zone an object with lifelink deals 
                            damage from.
                    702.15e If multiple sources with lifelink deal damage at the same time, they cause 
                            separate life gain events (see rule 118.9).
                            Example: A player controls Ajani’s Pridemate, which reads “Whenever you gain life, 
                                you may put a +1/+1 counter on Ajani’s Pridemate,” and two creatures with lifelink. 
                                The creatures with lifelink deal combat damage simultaneously. Ajani’s Pridemate’s 
                                ability triggers twice.
                    702.15f Multiple instances of lifelink on the same object are redundant.  
                */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

        #region Constructors
        public Lifelink()
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
