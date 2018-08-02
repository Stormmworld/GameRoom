using MTG.Model;
using MTG.Model.Objects;

namespace MTG.ArgumentDefintions
{
    public class AbilityArgs 
    {
        public int Damage { get; set; }
        public ActiveGame Game { get; set; }
        public int Life { get; set; }
        public Card OriginCard { get; set; }
        public Player OriginPlayer { get; set; }
        public Card TargetCard { get; set; }
        public Player TargetPlayer { get; set; }
    }
}
