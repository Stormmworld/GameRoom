using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Enumerations;
using MTG.Model.Abilities.Static;
using System;

namespace MTG.Model.Objects
{
    public class Damage
    {
        #region Events
        public event EventHandler OnApplyDamage;
        #endregion

        #region Properties
        public int BaseValue { get; set; }
        public int FinalValue { get { return BaseValue - Prevention; } }
        public Guid Id { get; private set; }
        public Card OriginCard { get; private set; }
        public Guid OriginPlayerId { get { return OriginCard.ControllerId; } }
        public int Prevention { get; private set; }
        #endregion

        #region Constructors
        public Damage(Card originCard)
        {
            OriginCard = originCard;
        }
        #endregion

        #region Operators
        public static bool operator ==(Damage x, Damage y)
        {
            return x.Equals(y);
        }
        public static bool operator !=(Damage x, Damage y)
        {
            return !(x == y);
        }
        #endregion

        #region Methods
        public void AddPrevention(int value)
        {
            Prevention += value;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Damage)) return false;
            return Id == ((Damage)obj).Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
        public void Process(Target target)
        {
            if (FinalValue > 0)
            {
                if (target.Type == TargetType.Player || target.Type == TargetType.Planeswalker)
                {
                    ApplyDamageEventArgs args = new ApplyDamageEventArgs()
                    {
                        DamageValue = FinalValue,
                        Target = target,
                    };
                    args.addDamageAttributtes(OriginCard);
                    OnApplyDamage?.Invoke(this, args);
                }
                else if (target.Type == TargetType.Card)
                {
                    ApplyDamageEventArgs args = new ApplyDamageEventArgs()
                    {
                        DamageValue = FinalValue,
                        Target = target,
                    };
                    args.addDamageAttributtes(OriginCard);
                    OnApplyDamage?.Invoke(this, args);
                }
                else
                    throw new NotImplementedException("Damage.Process: Target Type has no damage rules assignerd for it");
            }
        }
        #endregion
    }
}
