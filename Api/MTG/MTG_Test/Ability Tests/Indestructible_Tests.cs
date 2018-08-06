using System;
using System.Collections.Generic;
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
            List<string> indestructibleCardEvents = new List<string>();
            Card indestructibleCard = Mockers.Card_Mocker.MockCreature();
            indestructibleCard.Add(new Indestructible());
            indestructibleCard.OnCardDestroyed += delegate (object sender, EventArgs e) { indestructibleCardEvents.Add("Destroyed");};
            indestructibleCard.Destroy();
            Assert.IsFalse(indestructibleCardEvents.Contains("Destroyed"));

            List<string> destructibleCardEvents = new List<string>();
            Card destructibleCard = Mockers.Card_Mocker.Mock();
            destructibleCard.OnCardDestroyed += delegate (object sender, EventArgs e) { destructibleCardEvents.Add("Destroyed"); };
            destructibleCard.Destroy();
            Assert.IsTrue(destructibleCardEvents.Contains("Destroyed"));
        }
    }
}
