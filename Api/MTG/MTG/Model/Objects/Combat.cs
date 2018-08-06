using MTG.Helpers;
using MTG.Model.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTG.Model.Objects
{
    public class Combat
    {
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
        public void AddAttacker(Card card, Guid bandId = new Guid())
        {
            if (bandId == new Guid())
                _Attackers.Add(new AttackingCreature(card));
            else
            {
                Band bandToJoin = _AttackingBands.FirstOrDefault(o=>o.Id == bandId);
                if (bandToJoin != null)
                    bandToJoin.AddMember(card);
                else
                {
                    Band newBand = new Band(Enumerations.BandTypes.Attacking);
                    newBand.AddMember(card);
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
        public void CommitDamage()
        {
            foreach (AttackingCreature attacker in _Attackers)
                attacker.CommitDamage();
            foreach (Band attackerBand in _AttackingBands)
                attackerBand.CommitDamage();
        }
        #endregion
    }
}
