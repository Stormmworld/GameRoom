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
        public void Game_AddAttacker()
        {
            string player1SocketId = "p1";
            string player2SocketId = "p2";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player2" };

            ActiveGame game = new ActiveGame();
            game.Add(player1, Card_Mocker.MockDeck());
            game.Add(player2, Card_Mocker.MockDeck());
            game.StartGame();

            Game_Helper.ProcessToPhase(player1.Id, GamePhases.PreCombat_Main, ref game);
            PlayerHand hand =  game.GetPlayerHand(player1.Id);
            Spell spellToCast = hand.Spells.FirstOrDefault(o=>o.Enabled && !o.IsLand);
            //fill manapool


            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_DeclareAttackers, ref game);
            DeclareAttackerRequest attackRequest = new DeclareAttackerRequest()
            {
                AttackerId = Card_Mocker.MockCreature(3, 3).Id,
                Target = new AttackableTarget()
                {
                    Id = player1.Id,
                    AttackableType = AttackableType.Player,
                    Name = player1.Name,
                },
            };
            game.DeclareAttacker(attackRequest);
            CombatResponse combat = game.GetActiveCombat();
            Assert.IsTrue(combat.AttackingCreatures.FirstOrDefault(o => o.Card.Id == attackRequest.AttackerId) != null);
        }
    }
}
  