using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Model.Abilities.Static;
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
            indestructibleCard.OnCardEvent += delegate (object sender, EventArgs e) { if (e is DestroyCardEventArgs) indestructibleCardEvents.Add("Destroyed");};
            indestructibleCard.Destroy();
            Assert.IsFalse(indestructibleCardEvents.Contains("Destroyed"));

            List<string> destructibleCardEvents = new List<string>();
            Card destructibleCard = Mockers.Card_Mocker.Mock();
            destructibleCard.OnCardEvent += delegate (object sender, EventArgs e) { if(e is DestroyCardEventArgs) destructibleCardEvents.Add("Destroyed"); };
            destructibleCard.Destroy();
            Assert.IsTrue(destructibleCardEvents.Contains("Destroyed"));
        }
    }
}
