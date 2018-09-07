using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Static
{
    public class ConvertToCreature: StaticAbility
    {
        #region Properties
        public int Power { get; private set; }
        public int Toughness { get; private set; }
        #endregion

        #region Constructors
        public ConvertToCreature(int power, int toughness) : base(GamePhase.None)
        {
            Power = power;
            Toughness = toughness;
        }
        public ConvertToCreature(int power, int toughness, GamePhase removeAtPhase) : base(removeAtPhase)
        {
            Power = power;
            Toughness = toughness;
        }
        #endregion
    }
}
