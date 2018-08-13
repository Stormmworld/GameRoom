using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.Enumerations;
using MTG.Model;
using MTG.Model.Counters;
using MTG.Model.Objects;
using MTG_Test.Mockers;
using System;
using System.Collections.Generic;

namespace MTG_Test.Game_Tests
{
    [TestClass]
    public class Damage_Tests
    {
        [TestMethod]
        public void Damage_Deathtouch_AddedToPlayer()
        {
            Player receivingPlayer = Player_Mocker.Mock();
            int initialLife = receivingPlayer.Life;
            ApplyDamageEventArgs deathtouchDamageArgs = ApplyDamageEventArgs_Mocker.Mock_Deathtoucn();
            deathtouchDamageArgs.Target = new Target() { Id = receivingPlayer.Id, Type = TargetType.Player };
            receivingPlayer.ApplyDamage(deathtouchDamageArgs);
            Assert.AreEqual(receivingPlayer.Life, initialLife - deathtouchDamageArgs.DamageValue);
        }
        [TestMethod]
        public void Damage_Deathtouch_AddedToPlaneswalker()
        {
            Card planeswalker = Card_Mocker.MockPlaneswalker(4);
            int initialLoyalty = planeswalker.GetCountersByType(typeof(Loyalty)).Count;
            ApplyDamageEventArgs deathtouchDamageArgs = ApplyDamageEventArgs_Mocker.Mock_Deathtoucn();
            deathtouchDamageArgs.Target = new Target() { Id = planeswalker.Id, Type = TargetType.Planeswalker };
            planeswalker.ApplyDamage(deathtouchDamageArgs);
            Assert.AreEqual(planeswalker.GetCountersByType(typeof(Loyalty)).Count, initialLoyalty - deathtouchDamageArgs.DamageValue);
        }
        [TestMethod]
        public void Damage_Deathtouch_AddedToCreature()
        {
            List<string> creatureCardEvents = new List<string>();
            Card creature = Card_Mocker.MockCreature(9, 9);
            creature.OnCardDestroyed += delegate (object sender, EventArgs e) { creatureCardEvents.Add("Destroyed"); };

            ApplyDamageEventArgs deathtouchDamageArgs = ApplyDamageEventArgs_Mocker.Mock_Deathtoucn();
            deathtouchDamageArgs.Target = new Target() { Id = creature.Id, Type = TargetType.Card };
            creature.ApplyDamage(deathtouchDamageArgs);

            Assert.IsTrue(creatureCardEvents.Contains("Destroyed"));
        }
        [TestMethod]
        public void Damage_Normal_AddedToPlayer()
        {
            Player receivingPlayer = Player_Mocker.Mock();
            int initialLife = receivingPlayer.Life;
            ApplyDamageEventArgs damageArgs = new ApplyDamageEventArgs() { Target = new Target() { Type = TargetType.Player, Id = receivingPlayer .Id} };
            receivingPlayer.ApplyDamage(damageArgs);
            Assert.AreEqual(receivingPlayer.Life, initialLife - damageArgs.DamageValue);
        }
        [TestMethod]
        public void Damage_Normal_AddedToPlaneswalker()
        {
            Card planeswalker = Card_Mocker.MockPlaneswalker(4);
            int initialLoyalty = planeswalker.GetCountersByType(typeof(Loyalty)).Count;
            ApplyDamageEventArgs damageArgs = ApplyDamageEventArgs_Mocker.Mock();
            planeswalker.ApplyDamage(damageArgs);
            Assert.AreEqual(planeswalker.GetCountersByType(typeof(Loyalty)).Count, initialLoyalty - damageArgs.DamageValue);
        }
        [TestMethod]
        public void Damage_Normal_AddedToCreature()
        {
            Card creature = Card_Mocker.MockCreature(9, 9);
            int initialDamage = 0;
            ApplyDamageEventArgs damageArgs = ApplyDamageEventArgs_Mocker.Mock();
            creature.ApplyDamage(damageArgs);
            int afterDamage = 0;
            foreach (int damage in creature.Damage)
                afterDamage += damage;
            Assert.AreEqual(afterDamage, initialDamage + damageArgs.DamageValue);
        }
    }
}
