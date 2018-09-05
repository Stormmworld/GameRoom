using System;
using System.Collections.Generic;
using System.Linq;
using MTG.Enumerations;
using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Counters;
using MTG.Model.Game;

namespace MTG.Model.Cards._Base
{
    public class Creature : Permanent, ICreature
    {
        #region Variables
        private List<IDamage> _Damage;
        private int _BasePower, _BaseToughness;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IDamage> Damage { get { return _Damage.AsReadOnly(); } }
        #endregion

        #region Properties
        public virtual SubType SubtypeModifier { get; internal set; }
        public virtual int Power
        {
            get
            {
                int retVal = _BasePower;
                foreach(PlusXPlusY counter in Counters.Where(o => o is PlusXPlusY))
                    retVal += counter.X;
                switch (ToughnessModifier)
                {
                    case Modifier.SubTypeControllerControls:
                        retVal += Controller.BattleField.FilteredCards(o => o.SubTypes.Contains(SubtypeModifier)).Count;
                        break;
                    case Modifier.SubTypeDefenderControls:
                        retVal += DefendingPlayer.BattleField.FilteredCards(o => o.SubTypes.Contains(SubtypeModifier)).Count;
                        break;
                    default:
                        break;
                }
                return retVal;
            }
        }
        public virtual Modifier PowerModifier { get; internal set; }
        public Player DefendingPlayer { get; internal set; }
        public virtual int Toughness
        {
            get
            {
                int retVal = _BaseToughness;
                foreach (PlusXPlusY counter in Counters.Where(o => o is PlusXPlusY))
                    retVal += counter.Y;
                switch (ToughnessModifier)
                {
                    case Modifier.SubTypeControllerControls:
                        retVal += Controller.BattleField.FilteredCards(o => o.SubTypes.Contains(SubtypeModifier)).Count;
                        break;
                    case Modifier.SubTypeDefenderControls:
                        retVal += DefendingPlayer.BattleField.FilteredCards(o => o.SubTypes.Contains(SubtypeModifier)).Count;
                        break;
                    default:
                        break;
                }
                return retVal;
            }
        }
        public virtual Modifier ToughnessModifier { get; internal set; }
        #endregion

        #region Constructors
        internal Creature(int power = 0, int toughness = 0)
        {
            _Damage = new List<IDamage>();
            Set(power, toughness);
        }
        #endregion

        #region Methods
        public virtual void Add(IDamage damage)
        {
            _Damage.Add(damage);
        }
        public virtual void Attack(ref Player defendingPlayer)
        {
            DefendingPlayer = defendingPlayer;
        }
        public virtual IDamage CreateCombatDamage()
        {
            throw new NotImplementedException("Creature.CreateCombatDamage");
        }
        public virtual void EndCombat()
        {
            throw new NotImplementedException("Creature.EndCombat");
        }
        public virtual void Remove(IDamage damage)
        {
            _Damage.Remove(damage);
        }
        public virtual void Set(int power, int toughness)
        {
            _BasePower = power;
            _BaseToughness = toughness;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
        #endregion
    }
}
