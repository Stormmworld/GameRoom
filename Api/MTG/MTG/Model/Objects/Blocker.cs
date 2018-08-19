using MTG.ArgumentDefintions.Effect_Triggered_Arguments;
using MTG.Helpers;
using MTG.Model.Effects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Blocker
    {
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered;
        #endregion

        #region Variables
        private List<Card> _Blockers;
        private List<Band> _BlockingBands;
        #endregion

        #region Properties
        public IReadOnlyCollection<Card> Blockers { get { return _Blockers.AsReadOnly(); } }
        public IReadOnlyCollection<Band> BlockingBands { get { return _BlockingBands.AsReadOnly(); } }
        public AttackableTarget Defender { get; set; }
        #endregion

        #region Constructors
        public Blocker()
        {
            _Blockers = new List<Card>();
            _BlockingBands = new List<Band>();
            Defender = new AttackableTarget();
        }
        #endregion

        #region Methods
        public void Add(Card blocker)
        {
            _Blockers.Add(blocker);
        }
        public void Add(Card blocker, Guid bandId)
        {
            Band bandToJoin = _BlockingBands.FirstOrDefault(o=>o.Id == bandId);
            if (bandToJoin != null)
                bandToJoin.AddMember(blocker);
            else
                Add(blocker);
        }
        public void AssignDamage(bool isFirstStrike, Card attacker, Player attackingPlayer)
        {

            int attackerDamage = 0;
            if ((isFirstStrike && CardHelper.HasFirstStrikeDamage(attacker)) || (!isFirstStrike && CardHelper.HasNormalStrikeDamage(attacker)))
                attackerDamage = attacker.Power;

            if (Blockers.Count == 0 && BlockingBands.Count == 0 && attackerDamage > 0)
            {//No Blockers
                OnEffectTriggered?.Invoke(this, new EffectTriggeredEventArgs(new DamageEffect(new Damage(attacker) { BaseValue = attackerDamage }, Defender.GenerateTarget())));
                return;
            }

            if (Blockers.Count == 1 && BlockingBands.Count == 0 && attackerDamage > 0)
            {//Single Defender
                Card blocker = _Blockers[0];
                if ((isFirstStrike && CardHelper.HasFirstStrikeDamage(blocker)) || (!isFirstStrike && CardHelper.HasNormalStrikeDamage(blocker)))
                    OnEffectTriggered?.Invoke(this, new EffectTriggeredEventArgs(new DamageEffect(new Damage(blocker) {  BaseValue = blocker.Power }, attacker.GenerateTarget())));
                if (attackerDamage > 0)
                    OnEffectTriggered?.Invoke(this, new EffectTriggeredEventArgs(new DamageEffect(new Damage(attacker) { BaseValue = attackerDamage }, blocker.GenerateTarget())));
                return;
            }
            
            if (Blockers.Count > 0 && attackerDamage > 0)
            {//Multi Defender
                throw new NotImplementedException("Blockers.AssignDamage - multiple blockers");
            }

            if (BlockingBands.Count > 0 && attackerDamage > 0)
            {//Bands Defending
                throw new NotImplementedException("Blockers.AssignDamage - banded blockers");
            }
        }
        #endregion
    }
}
