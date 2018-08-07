using MTG.Model.Objects;

namespace MTG_Test.Mockers
{
    public class Combat_Mocker
    {
        public static Combat Mock()
        {
            return new Combat();
        }
        public static AttackingCreature MockAttackingCreature(int power = 3, int toughness = 3)
        {
            return new AttackingCreature(Card_Mocker.MockCreature(power,toughness));
        }
    }
}
