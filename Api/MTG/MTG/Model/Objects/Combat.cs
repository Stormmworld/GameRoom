using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Combat
    {
        #region Events
        public event EventHandler OnEffectTriggered;
        #endregion

        #region Variables
        private List<AttackingCreature> _Attackers;
        private List<Band> _AttackingBands;
        #endregion

        #region Properties
        public IReadOnlyCollection<AttackingCreature> Attackers { get { return _Attackers.AsReadOnly(); } }
        public IReadOnlyCollection<Band> AttackingBands { get { return _AttackingBands.AsReadOnly(); } }
        #endregion

        #region Constructors
        public Combat()
        {
            _Attackers = new List<AttackingCreature>();
            _AttackingBands = new List<Band>();
        }
        #endregion

        #region Methods
        public void AddAttacker(AttackingCreature attacker, Guid bandId = new Guid())
        {
            if (bandId == new Guid())
                _Attackers.Add(attacker);
            else
            {
                Band bandToJoin = _AttackingBands.FirstOrDefault(o=>o.Id == bandId);
                if (bandToJoin != null)
                    bandToJoin.AddMember(attacker.Card);
                else
                {
                    Band newBand = new Band(Enumerations.BandTypes.Attacking);
                    newBand.AddMember(attacker.Card);
                    _AttackingBands.Add(newBand);
                }
            }
        }
        public void AddBlocker(Card card, Guid attackerId, Guid blockingBandId = new Guid())
        {
            AttackingCreature attackerToBlock = _Attackers.FirstOrDefault(o=>o.Id == attackerId);
            if (attackerToBlock != null)
                attackerToBlock.AddBlocker(card, blockingBandId);
            else
            {
                Band attackerBandToBlock = _AttackingBands.FirstOrDefault(o => o.Id == attackerId);
                if (attackerBandToBlock != null)
                    attackerBandToBlock.AddBlocker(card, blockingBandId);
            }
        }
        public void AssignDamage(bool isFirstStrike)
        {
            foreach (AttackingCreature attacker in _Attackers)
                attacker.AssignDamage(isFirstStrike);
            foreach (Band band in _AttackingBands)
                band.AssignDamage(isFirstStrike);
        }
        public void Clear()
        {
            _Attackers.Clear();
            _AttackingBands.Clear();
        }
        public void CommitDamage()
        {
            foreach (AttackingCreature attacker in _Attackers)
                attacker.CommitDamage();
            foreach (Band attackerBand in _AttackingBands)
                attackerBand.CommitDamage();
        }
        public bool HasAttackers()
        {
            return Attackers.Count > 0 || AttackingBands.Count > 0;
        }
        #endregion
    }
}
