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
        public Card OriginCard { get; set; }
        public Player OriginPlayer { get; set; }
        public int Prevention { get; private set; }
        public Target Target { get; set; }
        #endregion

        #region Constructors
        public Damage()
        {
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
        public void Process()
        {
            if (FinalValue > 0)
            {
                if (Target.Type == TargetType.Player || Target.Type == TargetType.Planeswalker)
                {
                    ApplyDamageEventArgs args = new ApplyDamageEventArgs()
                    {
                        DamageValue = FinalValue,
                        Target = Target,
                    };
                    args.addDamageAttributtes(OriginCard);
                    OnApplyDamage?.Invoke(this, args);
                }
                else if (Target.Type == TargetType.Card)
                {
                    if (OriginCard.HasAbility(typeof(Trample)))
                    {
                        //handle trample damage
                        throw new NotImplementedException("Damage.Process: Trample damage has not been accounted for");
                    }
                    else
                    {
                        ApplyDamageEventArgs args = new ApplyDamageEventArgs()
                        {
                            DamageValue = FinalValue,
                            Target = Target,
                        };
                        args.addDamageAttributtes(OriginCard);
                        OnApplyDamage?.Invoke(this, args);
                    }
                }
                else
                    throw new NotImplementedException("Damage.Process: Target Type has no damage rules assignerd for it");
            }
        }
        #endregion
    }
}
