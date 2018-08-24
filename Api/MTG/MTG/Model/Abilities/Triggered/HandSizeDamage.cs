using MTG.Interfaces.Ability_Interfaces;
using MTG.Enumerations;
using System;
using MTG.Interfaces;

namespace MTG.Model.Abilities.Triggered
{
    public class HandSizeDamage : ITriggeredAbility
    {
        /*
        * HandSizeDamage
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Properties
        public Guid BoundCardId { get; set; }
        public Comparator Comparator { get; private set; }
        public int DamagePerCard { get; private set; }
        public int HandSize { get; private set; }
        public Guid Id { get; private set; }
        public EffectTrigger Trigger { get; private set; }
        #endregion

        #region Constructors
        private HandSizeDamage()
        {
            Id = Guid.NewGuid();
        }
        public HandSizeDamage(EffectTrigger trigger, int handSize, Comparator comparator, int damagePerCard) : this()
        {
            Trigger = trigger;
            Comparator = comparator;
            DamagePerCard = damagePerCard;
            HandSize = handSize;
        }
        public HandSizeDamage(EffectTrigger trigger, int handSize, Comparator comparator, int damagePerCard, Guid boundCardId) : this(trigger, handSize, comparator, damagePerCard)
        {
            BoundCardId = boundCardId;
        }
        #endregion

        #region Methods
        public void Process(ITriggeredAbilityArgs args)
        {
            throw new NotImplementedException("HandSizeDamage.Process");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}