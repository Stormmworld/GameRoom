using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.DTO.Requests;
using MTG.Model;
using MTG.Model.Objects;
using MTG_Test.Mockers;

namespace MTG_Test.Game_Tests
{
    [TestClass]
    public class Game_Tests
    {
        [TestMethod]
        public void Game_ApplyCombatDamage_ToPlayer()
        {
            string player1SocketId = "p1";
            string player2SocketId = "p2";
            ActiveGame game = new ActiveGame();
            game.AddPlayer(player1SocketId, "Player 1", Card_Mocker.MockDeck());
            game.AddPlayer(player2SocketId, "Player 2", Card_Mocker.MockDeck());

            DeclareAttackerRequest attackRequest = new DeclareAttackerRequest();
            attackRequest.Attacker = Card_Mocker.MockCreature(3, 3);


            game.DeclareAttacker(attackRequest);
        }
    }
}
  