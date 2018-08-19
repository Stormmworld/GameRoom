using MTG.Model;
using MTG.Model.Objects;

namespace MTG_Test.Mockers
{
    public static class Damage_Mocker
    {
        public static Damage Mock()
        {
            return new Damage(Card_Mocker.Mock())
            {
                BaseValue = 1,
            };
        }
        public static Damage Mock(Card originCard, Player originPlayer, Target target, int damageValue)
        {
            return new Damage(originCard)
            {
                BaseValue = damageValue,
            };
        }
    }
}
