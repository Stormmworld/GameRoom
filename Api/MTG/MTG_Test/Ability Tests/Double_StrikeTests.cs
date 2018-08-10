using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG_Test.Ability_Tests
{
    [TestClass]
    public class Double_Strike_Tests
    {
        [TestMethod]
        public void Ability_Double_Strike()
        {
            Card doubleStrikeCard = Mockers.Card_Mocker.MockCreature();
            doubleStrikeCard.Add(new Double_Strike());
            Card normalStrikeCard = Mockers.Card_Mocker.MockCreature();

            Assert.IsTrue(doubleStrikeCard.HasAbility(typeof(Double_Strike)));
            Assert.IsFalse(normalStrikeCard.HasAbility(typeof(Double_Strike)));
        }
    }
}
