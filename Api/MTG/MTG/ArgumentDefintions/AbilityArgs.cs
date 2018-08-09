using MTG.Model;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions
{
    public class AbilityArgs 
    {
        #region Properties
        public int CardTypeCount { get; set; }
        public Damage Damage { get; set; }
        public ActiveGame Game { get; set; }
        public int LifeGain { get; set; }
        public int ManaCount { get; set; }
        public int ManaMultiplier { get; set; }
        public Card OriginCard { get; set; }
        public Player OriginPlayer { get; set; }
        public Card TargetCard { get; set; }
        public Player TargetPlayer { get; set; }
        #endregion

        #region Constructors
        public AbilityArgs()
        {
            Damage = new Damage();
        }
        #endregion
    }
}
