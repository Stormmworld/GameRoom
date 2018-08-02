using MTG.Enumerations;
using MTG.Helpers;
using MTGModel.Objects;
using System;

namespace MTG.Model.Objects
{
    public class Damage
    {
        #region Properties
        public int FinalValue { get { return Value - Prevention; } }
        public Card OriginCard { get; private set; }
        public Player OriginPlayer { get; private set; }
        public int Prevention { get; private set; }
        public Target Target { get; private set; }
        public DamageTypes Type { get; private set; }
        private int Value { get; set; }
        #endregion

        #region Constructors
        public Damage(Player originPlayer, Card originCard, Target target, DamageTypes type, int value)
        {
            OriginCard = originCard;
            OriginPlayer = originPlayer;
            Target = target;
            Type = type;
            Value = value;
            if (TargetHelper.TargetIsCard(Target.Type))
                ProcessTargetCard();
        }
        #endregion

        #region Methods
        public void AddPrevention(int value)
        {
            Prevention += value;
        }
        public void Process()
        {
            throw new NotImplementedException("Damage.Process");
        }
        private void ProcessTargetCard()
        {//

        }
        #endregion
    }
}
