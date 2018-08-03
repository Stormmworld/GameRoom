using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG_Test.Ability_Tests
{
    [TestClass]
    public class Indestructible_Tests
    {
        [TestMethod]
        public void Ability_Indestructible()
        {
            Card indestructibleCard = Mockers.Card_Mocker.MockCreature();
            indestructibleCard.Add(new Indestructible());
            indestructibleCard.Abilities[0].Process( new AbilityArgs() { OriginCard = indestructibleCard }) ;
            Card destructibleCard = Mockers.Card_Mocker.Mock();
            Assert.IsFalse(indestructibleCard.CanBeDestroyed);
            Assert.IsTrue(destructibleCard.CanBeDestroyed);
        }
    }
}
