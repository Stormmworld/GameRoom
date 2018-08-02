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
        public void AppliesEffect()
        {
            Card indestructibleCard = Mockers.Card_Mocker.MockWithAbility(new Indestructible());
            indestructibleCard.Abilities[0].Process( new AbilityArgs() { OriginCard = indestructibleCard }) ;
                     


            Assert.IsFalse(indestructibleCard.CanBeDestroyed);
        }
    }
}
