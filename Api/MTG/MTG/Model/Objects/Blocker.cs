using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Blocker
    {
        #region Events
        public event EventHandler OnPendingActionTriggered, OnPendingDamage;
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

            if (Blockers.Count == 0 && BlockingBands.Count == 0 && attackerDamage>0)
            {//No Blockers
                PendingDamageEventArgs args = new PendingDamageEventArgs()
                {
                    Damage = new Damage()
                    {
                        OriginCard = attacker,
                        BaseValue = attackerDamage,
                        OriginPlayer = attackingPlayer,
                        Target = Defender.GenerateTarget(),
                    }
                };
                OnPendingDamage?.Invoke(this, args);
                return;
            }

            if (Blockers.Count == 1 && BlockingBands.Count == 0 && attackerDamage > 0)
            {//Single Defender
                Card blocker = _Blockers[0];
                if ((isFirstStrike && CardHelper.HasFirstStrikeDamage(blocker)) || (!isFirstStrike && CardHelper.HasNormalStrikeDamage(blocker)))
                {
                    PendingDamageEventArgs args = new PendingDamageEventArgs()
                    {
                        Damage = new Damage()
                        {
                            OriginCard = blocker,
                            BaseValue = blocker.Power,
                            Target = attacker.GenerateTarget(),
                        }
                    };
                    OnPendingDamage?.Invoke(this, args);
                }
                if (attackerDamage > 0)
                {
                    PendingDamageEventArgs args = new PendingDamageEventArgs()
                    {
                        Damage = new Damage()
                        {
                            OriginCard = attacker,
                            BaseValue = attackerDamage,
                            OriginPlayer = attackingPlayer,
                            Target = blocker.GenerateTarget(),
                        }
                    };
                    OnPendingDamage?.Invoke(this, args);
                }
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
