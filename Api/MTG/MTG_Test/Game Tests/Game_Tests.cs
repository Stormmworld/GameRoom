using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.DTO.Objects;
using MTG.DTO.Requests;
using MTG.DTO.Responses;
using MTG.Enumerations;
using MTG.Model;
using MTG.Model.Objects;
using MTG_Test.Helpers;
using MTG_Test.Mockers;
using System.Linq;

namespace MTG_Test.Game_Tests
{
    [TestClass]
    public class Game_Tests
    {
        [TestMethod]
        public void Game_AddPlayer()
        {
            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            ActiveGame game = new ActiveGame();
            game.Add(player1, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == "p1"));
        }
        [TestMethod]
        public void Game_StartGame()
        {
            ActiveGame game = new ActiveGame();

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player1SocketId));

            game.StartGame();
            Assert.IsNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.None);

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player2SocketId));

            game.StartGame();
            Assert.IsNotNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.Beginning_Untap);
        }
        [TestMethod]
        public void Game_Mulligan()
        {
            ActiveGame game = new ActiveGame();

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_LandOnly());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player1SocketId));
            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player2SocketId));

            game.StartGame();
            Assert.IsNotNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.Beginning_Untap);
        }
        [TestMethod]
        public void Game_DrawPhase()
        {
            ActiveGame game = new ActiveGame();

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player1SocketId));
            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player2SocketId));

            game.StartGame();
            Assert.IsNotNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.Beginning_Untap);

            int player1HandSizeBeforeDraw = player1.Hand.Cards.Count;
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Beginning_Draw,ref game);
            Assert.AreEqual(player1HandSizeBeforeDraw + 1, player1.Hand.Cards.Count);

            int player2HandSizeBeforeDraw = player2.Hand.Cards.Count;
            Game_Helper.ProcessToPhase(player2.Id, GamePhases.Beginning_Draw, ref game);
            Assert.AreEqual(player2HandSizeBeforeDraw + 1, player2.Hand.Cards.Count);

        }
        [TestMethod]
        public void Game_PlayLand()
        {
            ActiveGame game = new ActiveGame();

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player1SocketId));

            game.StartGame();
            Assert.IsNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.None);

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player2SocketId));

            game.StartGame();
            Assert.IsNotNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.Beginning_Untap);
        }
    }
}
  