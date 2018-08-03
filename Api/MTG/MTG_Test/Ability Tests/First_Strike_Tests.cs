using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG_Test.Ability_Tests
{
    [TestClass]
    public class First_Strike_Tests
    {
        [TestMethod]
        public void Ability_First_Strike()
        {
            Card firstStrikeCard = Mockers.Card_Mocker.MockCreature();
            firstStrikeCard.Add(new First_Strike());
            Card normalStrikeCard = Mockers.Card_Mocker.MockCreature();

            Assert.IsFalse(normalStrikeCard.HasFirstStrike);
            Assert.IsFalse(firstStrikeCard.HasNormalStrike);
            Assert.IsTrue(firstStrikeCard.HasFirstStrike);
        }
    }
}
