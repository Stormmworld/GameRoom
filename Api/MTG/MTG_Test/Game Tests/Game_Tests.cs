using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.DTO.Objects;
using MTG.DTO.Requests;
using MTG.DTO.Requests.CompleteActions;
using MTG.DTO.Responses;
using MTG.Enumerations;
using MTG.Model;
using MTG.Model.Abilities;
using MTG.Model.Pending_Actions;
using MTG_Test.Helpers;
using MTG_Test.Mockers;
using System;
using System.Collections.Generic;
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
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_LandOnly());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            Assert.IsNull(game.ActivePlayer);
            Assert.AreNotEqual(game.ActivePhase, GamePhases.Beginning_Untap);
            Assert.IsTrue(pendingActionsReturned.Count == 1);
            Assert.IsTrue(pendingActionsReturned[0].PendingAction is MulliganPendingAction);
            Assert.IsTrue(((MulliganPendingAction)pendingActionsReturned[0].PendingAction).ActionPlayerId == player1.Id);
        }
        [TestMethod]
        public void Game_Mulligan_Accept()
        {
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_LandOnly());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            Assert.IsNull(game.ActivePlayer);
            Assert.AreNotEqual(game.ActivePhase, GamePhases.Beginning_Untap);
            Assert.IsTrue(pendingActionsReturned.Count == 1);
            Assert.IsTrue(pendingActionsReturned[0].PendingAction is MulliganPendingAction);
            MulliganPendingAction actionToComplete =  (MulliganPendingAction)pendingActionsReturned[0].PendingAction;
            Assert.IsTrue(actionToComplete.ActionPlayerId == player1.Id);

            MulliganCompleteActionRequest mulliganAction = new MulliganCompleteActionRequest()
            {
                ActionId = actionToComplete.Id,
                ActionPlayerId = actionToComplete.ActionPlayerId,
                Reshuffle = false,
            };
            game.CompleteAction(mulliganAction);
            Assert.IsNotNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.Beginning_Untap);
        }
        [TestMethod]
        public void Game_Mulligan_Reshuffle()
        {
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_LandOnly());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            Assert.IsNull(game.ActivePlayer);
            Assert.AreNotEqual(game.ActivePhase, GamePhases.Beginning_Untap);
            Assert.IsTrue(pendingActionsReturned.Count == 1);
            Assert.IsTrue(pendingActionsReturned[0].PendingAction is MulliganPendingAction);
            MulliganPendingAction actionToComplete = (MulliganPendingAction)pendingActionsReturned[0].PendingAction;
            Assert.IsTrue(actionToComplete.ActionPlayerId == player1.Id);

            MulliganCompleteActionRequest mulliganAction = new MulliganCompleteActionRequest()
            {
                ActionId = actionToComplete.Id,
                ActionPlayerId = actionToComplete.ActionPlayerId,
                Reshuffle = true,
            };
            pendingActionsReturned.Clear();
            game.CompleteAction(mulliganAction);
            Assert.IsNull(game.ActivePlayer);
            Assert.AreNotEqual(game.ActivePhase, GamePhases.Beginning_Untap);
            Assert.IsTrue(pendingActionsReturned.Count == 1);
            Assert.IsTrue(pendingActionsReturned[0].PendingAction is MulliganPendingAction);
            Assert.IsTrue(((MulliganPendingAction)pendingActionsReturned[0].PendingAction).ActionPlayerId == player1.Id);
        }
        [TestMethod]
        public void Game_DrawPhase()
        {
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            if (pendingActionsReturned.Count > 0)
            {
                foreach (PendingActionEventArgs action in pendingActionsReturned)
                {
                    MulliganPendingAction actionToComplete = (MulliganPendingAction)action.PendingAction;
                    MulliganCompleteActionRequest mulliganAction = new MulliganCompleteActionRequest()
                    {
                        ActionId = actionToComplete.Id,
                        ActionPlayerId = actionToComplete.ActionPlayerId,
                        Reshuffle = false,
                    };
                    game.CompleteAction(mulliganAction);
                }
            }

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
            #region Begin Game
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            if (pendingActionsReturned.Count > 0)
            {
                foreach (PendingActionEventArgs action in pendingActionsReturned)
                {
                    MulliganPendingAction actionToComplete = (MulliganPendingAction)action.PendingAction;
                    MulliganCompleteActionRequest mulliganAction = new MulliganCompleteActionRequest()
                    {
                        ActionId = actionToComplete.Id,
                        ActionPlayerId = actionToComplete.ActionPlayerId,
                        Reshuffle = false,
                    };
                    game.CompleteAction(mulliganAction);
                }
            }
            #endregion
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells = game.GetPlayerHand(player1.Id).Spells;
            Spell land = spells.FirstOrDefault(o => o.IsLand);
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = land.CardId });
            Assert.IsTrue(response.Success);
            Assert.AreEqual(land.CardId, response.SpellId);
            Assert.IsTrue(player1.Battlefield.Find(land.CardId) != null);
        }
        [TestMethod]
        public void Game_TapLandForMana()
        {
            #region Begin Game
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_CreaturesAndLand());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            if (pendingActionsReturned.Count > 0)
            {
                foreach (PendingActionEventArgs action in pendingActionsReturned)
                {
                    MulliganPendingAction actionToComplete = (MulliganPendingAction)action.PendingAction;
                    MulliganCompleteActionRequest mulliganAction = new MulliganCompleteActionRequest()
                    {
                        ActionId = actionToComplete.Id,
                        ActionPlayerId = actionToComplete.ActionPlayerId,
                        Reshuffle = false,
                    };
                    game.CompleteAction(mulliganAction);
                }
            }
            #endregion
            #region Play Land
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells = game.GetPlayerHand(player1.Id).Spells;
            Spell land = spells.FirstOrDefault(o => o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = land.CardId });
            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o=>o.HasType(CardType.Land))[0].Id;
            #endregion

            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            Assert.IsTrue(activateResponse.Abilities.Count > 0);
            Assert.IsTrue(activateResponse.Abilities[0] is ManaSource);

            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            Assert.IsTrue(selectResponse.Success);
            Assert.IsTrue(player1.ManaPool.BlueMana.Count == 1);
        }
        [TestMethod]
        public void Game_PlayCreature()
        {
            #region Begin Game
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_CreaturesAndLand());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck());

            game.StartGame();
            if (pendingActionsReturned.Count > 0)
            {
                foreach (PendingActionEventArgs action in pendingActionsReturned)
                {
                    MulliganPendingAction actionToComplete = (MulliganPendingAction)action.PendingAction;
                    MulliganCompleteActionRequest mulliganAction = new MulliganCompleteActionRequest()
                    {
                        ActionId = actionToComplete.Id,
                        ActionPlayerId = actionToComplete.ActionPlayerId,
                        Reshuffle = false,
                    };
                    game.CompleteAction(mulliganAction);
                }
            }
            #endregion
            #region Play Land
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells = game.GetPlayerHand(player1.Id).Spells;
            Spell land = spells.FirstOrDefault(o => o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = land.CardId });
            #endregion

            Spell creatureSpell = spells.FirstOrDefault(o => !o.IsLand);
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = land.CardId });
            Assert.IsTrue(response.Success);
            Assert.AreEqual(creatureSpell.CardId, response.SpellId);
        }
    }
}
  