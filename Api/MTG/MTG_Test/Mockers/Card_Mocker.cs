using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG_Test.Mockers
{
    public static class Card_Mocker
    {
        public static Card Mock()
        {
            return new Card()
            {
                Name = "Test Card",
            };
        }        
        public static Card MockCreature( int power = 3, int toughness = 3)
        {
            Card retVal = new Card(power, toughness)
            {
                Name = "Test Creature"
            };
            retVal.Add(CardType.Creature);
            return retVal;
        }
        public static Card MockCreatureWithAbility(IAbility ability, int power = 3, int toughness = 3)
        {
            Card retVal = new Card(power, toughness)
            {
                Name = "Test Creature with " + ability.ToString()
            };
            retVal.Add(CardType.Creature);
            retVal.Add(ability);
            return retVal;
        }
        public static Card MockPlaneswalker(int loyaltyCount)
        {
            Card retVal = new Card()
            {
                Name = "Test Planeswalker"
            };
            for (int i = 0; i < loyaltyCount; i++)
                retVal.Add(new Counter() { CounterType = MTG.Enumerations.CounterType.Loyalty });
            retVal.Add(CardType.Planeswalker);
            return retVal;
        }
    }
}
