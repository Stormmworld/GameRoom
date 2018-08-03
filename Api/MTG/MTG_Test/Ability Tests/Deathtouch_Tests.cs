using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG_Test.Ability_Tests
{
    [TestClass]
    public class Deathtouch_Tests
    {
        [TestMethod]
        public void Ability_Deathtouch_Creature_NoDamage()
        {
            Card deathtouchCard = Mockers.Card_Mocker.MockCreature();
            deathtouchCard.Add(new Deathtouch());
            Card targetCard = Mockers.Card_Mocker.MockCreature();
            AbilityArgs args = new AbilityArgs()
            {
                OriginCard = deathtouchCard,
                TargetCard = targetCard,
                Damage = 0,
            };
            deathtouchCard.Abilities[0].Process(args);
            Assert.IsFalse(targetCard.SufferingFromDeathtouchEffect);
        }
        [TestMethod]
        public void Ability_Deathtouch_Creature_Damage()
        {
            Card deathtouchCard = Mockers.Card_Mocker.MockCreature();
            deathtouchCard.Add(new Deathtouch());
            Card targetCard = Mockers.Card_Mocker.MockCreature();
            AbilityArgs args = new AbilityArgs()
            {
                OriginCard = deathtouchCard,
                TargetCard = targetCard,
                Damage = 1,
            };
            deathtouchCard.Abilities[0].Process(args);
            Assert.IsTrue(targetCard.SufferingFromDeathtouchEffect);
        }
        [TestMethod]
        public void Ability_Deathtouch_Planeswalker_NoDamage()
        {
            Card deathtouchCard = Mockers.Card_Mocker.MockCreature();
            deathtouchCard.Add(new Deathtouch());
            Card targetCard = Mockers.Card_Mocker.MockPlaneswalker(5);
            AbilityArgs args = new AbilityArgs()
            {
                OriginCard = deathtouchCard,
                TargetCard = targetCard,                
                Damage = 0,
            };
            deathtouchCard.Abilities[0].Process(args);
            Assert.IsFalse(targetCard.SufferingFromDeathtouchEffect);
        }
        [TestMethod]
        public void Ability_Deathtouch_Planeswalker_Damage()
        {
            Card deathtouchCard = Mockers.Card_Mocker.MockCreature();
            deathtouchCard.Add(new Deathtouch());
            Card targetCard = Mockers.Card_Mocker.MockPlaneswalker(5);
            AbilityArgs args = new AbilityArgs()
            {
                OriginCard = deathtouchCard,
                TargetCard = targetCard,
                Damage = 1,
            };
            deathtouchCard.Abilities[0].Process(args);
            Assert.IsFalse(targetCard.SufferingFromDeathtouchEffect);
        }
    }
}
