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

        public static Card MockWithAbility(IAbility ability)
        {
            Card retVal = Mock();
            retVal.Add(ability);
            return retVal;
        }
    }
}
