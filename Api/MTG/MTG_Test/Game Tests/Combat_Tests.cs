//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MTG.Model.Abilities.Static;
//using MTG.Model.Objects;
//using MTG_Test.Mockers;

//namespace MTG_Test.Game_Tests
//{
//    [TestClass]
//    public class Combat_Tests
//    {
//        [TestMethod]
//        public void Combat_AttackerDoubleStrike_Vs_BlockerNormalStrike()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            Card AttackerWithDoubleStrike = Card_Mocker.MockCreatureWithAbility(new Double_Strike(),2, 3);
//            Card BlockerWithNormalStrike = Card_Mocker.MockCreature(4, 4);

//            combat.AddAttacker(new AttackingCreature(AttackerWithDoubleStrike));
//            foreach (AttackingCreature attacker in combat.Attackers)
//                combat.AddBlocker(BlockerWithNormalStrike, attacker.Id);
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_BlockerDoubleStrike_Vs_AttackerNormalStrike()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            Card BlockerWithDoubleStrike = Card_Mocker.MockCreatureWithAbility(new Double_Strike(), 2, 3);
//            Card AttackerWithNormalStrike = Card_Mocker.MockCreature(4, 4);

//            combat.AddAttacker(new AttackingCreature(AttackerWithNormalStrike));
//            foreach (AttackingCreature attacker in combat.Attackers)
//                combat.AddBlocker(BlockerWithDoubleStrike, attacker.Id);
//            throw new NotImplementedException();

//        }
//        [TestMethod]
//        public void Combat_FirstStrike_Vs_NormalStrike()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_NormalStrike_Vs_NormalStrike()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_NoBlocker()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_NoBlocker_WithBodyguard()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_Blocker_WithBodyguard()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_Blocker_WithBodyguard_Trample()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();
//        }
//        [TestMethod]
//        public void Combat_TrampleDamage()
//        {
//            Combat combat = Combat_Mocker.Mock();
//            throw new NotImplementedException();

//        }
//    }
//}
