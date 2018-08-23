using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG.ArgumentDefintions.Event_Arguments;
using MTG.DTO.Objects;
using MTG.DTO.Requests;
using MTG.DTO.Requests.CompleteActions;
using MTG.DTO.Responses;
using MTG.Enumerations;
using MTG.Model;
using MTG.Model.Abilities;
using MTG.Model.Abilities.Activated;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Objects;
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
            game.Add(player1, Card_Mocker.MockDeck_NoMulligan());
            Assert.IsNotNull(game.Players.FirstOrDefault(o => o.SocketId == player1SocketId));

            game.StartGame();
            Assert.IsNull(game.ActivePlayer);
            Assert.AreEqual(game.ActivePhase, GamePhases.None);

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck_NoMulligan());
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
            Assert.IsTrue(player1.Battlefield.FirstOrDefault(land.CardId) != null);
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
            #endregion

            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o=>o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            Assert.IsTrue(activateResponse.Abilities.Count > 0);
            Assert.IsTrue(activateResponse.Abilities[0] is ManaSource);

            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            Assert.IsTrue(selectResponse.Success);
            Assert.IsTrue(player1.ManaPool.BlueMana.Count == 1);
            Assert.IsTrue(player1.Battlefield.FilteredCards(o => o.Id == land.CardId)[0].Tapped);
        }
        [TestMethod]
        public void Game_CastCreature()
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
            #region Tap Land For Mana
            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            #endregion

            Spell creatureSpell = spells.FirstOrDefault(o => !o.IsLand);
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = creatureSpell.CardId });
            Assert.IsTrue(response.Success);
            Assert.AreEqual(creatureSpell.CardId, response.SpellId);
            Assert.IsTrue(game.Stack.FilteredCards(o => o.Card.Id == creatureSpell.CardId).Count == 1);
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
            #region Tap Land For Mana
            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell = spells.FirstOrDefault(o => !o.IsLand);
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = creatureSpell.CardId });
            #endregion

            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            Assert.IsTrue(player1.Battlefield.Cards.FirstOrDefault(o => o.Id == creatureSpell.CardId) != null);
        }
        [TestMethod]
        public void Game_CastInstant()
        {
            #region Begin Game
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_InstantsAndLand());

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
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Beginning_Upkeep,ref game);
            #region Tap Land For Mana
            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            #endregion
            Spell instant = spells.FirstOrDefault(o=> !o.IsLand);
            GetSpellOptionsResponse optionsResponse = game.GetSpellOptions(new GetSpellOptionsRequest() { PlayerId = player1.Id, SpellId = instant.CardId });
            optionsResponse.Abilities[0].Target = new MTG.Model.Objects.Target() { Type = TargetType.Player, Id = player2.Id};
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = instant.CardId, Abilities = new List<SelectableAbility>() { optionsResponse.Abilities[0], } });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            Assert.IsTrue(player2.Life < 20);
        }
        [TestMethod]
        public void Game_SummoningSickness()
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
            #region Tap Land For Mana
            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell = spells.FirstOrDefault(o => !o.IsLand);
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = creatureSpell.CardId });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            #endregion
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_DeclareAttackers,ref game);
            game.DeclareAttacker(new DeclareAttackerRequest() { AttackerId = creatureSpell.CardId, Target=new MTG.Model.Objects.AttackableTarget() { AttackableType = AttackableType.Player, Id = player2.Id}  });
            CombatResponse combat = game.GetActiveCombat();
            Assert.IsTrue(combat.AttackingCreatures.Count == 0);
        }
        [TestMethod]
        public void Game_AttackPlayer()
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
            #region Tap Land For Mana
            Guid landInBattleFieldId = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId });
            SelectAbilityResponse selectResponse = game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse.Abilities[0].Id, CardId = activateResponse.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell = spells.FirstOrDefault(o => !o.IsLand);
            CastSpellResponse response = game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = creatureSpell.CardId });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            #endregion
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Ending_End, ref game);
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_DeclareAttackers, ref game);
            game.DeclareAttacker(new DeclareAttackerRequest() { AttackerId = creatureSpell.CardId, Target = new MTG.Model.Objects.AttackableTarget() { AttackableType = AttackableType.Player, Id = player2.Id } });
            CombatResponse combat = game.GetActiveCombat();
            Assert.AreEqual(combat.AttackingCreatures.Count , 1);
            Assert.AreEqual(combat.AttackingCreatures[0].Card.Id , creatureSpell.CardId);
            Assert.AreEqual(player2.Life, 20);
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_Ending, ref game);
            Assert.AreEqual(player2.Life, 20 - combat.AttackingCreatures[0].Card.Power);
        }
        [TestMethod]
        public void Game_AttackPlayer_DeclareBlocker()
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
            game.Add(player2, Card_Mocker.MockDeck_CreaturesAndLand());

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
            #region Player 1
            #region Play Land
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells1 = game.GetPlayerHand(player1.Id).Spells;
            Spell land1 = spells1.FirstOrDefault(o => o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = land1.CardId });
            #endregion
            #region Tap Land For Mana
            Guid landInBattleFieldId1 = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse1 = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId1 });
            game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse1.Abilities[0].Id, CardId = activateResponse1.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell1 = spells1.FirstOrDefault(o => !o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = creatureSpell1.CardId });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            #endregion
            #endregion
            #region Player 2
            #region Play Land
            Game_Helper.ProcessToPhase(player2.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells2 = game.GetPlayerHand(player2.Id).Spells;
            Spell land2 = spells2.FirstOrDefault(o => o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player2.Id, SpellId = land2.CardId });
            #endregion
            #region Tap Land For Mana
            Guid landInBattleFieldId2 = player2.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse2 = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId2 });
            game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse2.Abilities[0].Id, CardId = activateResponse2.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell2 = spells2.FirstOrDefault(o => !o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player2.Id, SpellId = creatureSpell2.CardId });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            #endregion
            #endregion
            #region Declare Attackers
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_DeclareAttackers, ref game);
            game.DeclareAttacker(new DeclareAttackerRequest() { AttackerId = creatureSpell1.CardId, Target = new MTG.Model.Objects.AttackableTarget() { AttackableType = AttackableType.Player, Id = player2.Id } });
            #endregion
            game.DeclareBlocker(new DeclareBlockerRequest() { AttackerId = creatureSpell1.CardId , BlockerId = creatureSpell2.CardId });
            Assert.AreEqual(player2.Life, 20);
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_Ending, ref game);
            Card defendingCreature = game.Players.First(o => o.Id == player2.Id).FindCard(creatureSpell2.CardId);
            Card attackingCreature = game.Players.First(o => o.Id == player1.Id).FindCard(creatureSpell1.CardId);
            int defendingCreatureDamageTaken = 0;
            foreach (int damage in defendingCreature.Damage)
                defendingCreatureDamageTaken += damage;
            int attackingCreatureDamageTaken = 0;
            foreach (int damage in attackingCreature.Damage)
                attackingCreatureDamageTaken += damage;
            Assert.AreEqual(defendingCreatureDamageTaken, attackingCreature.Power);
            Assert.AreEqual(attackingCreatureDamageTaken, defendingCreature.Power);
            Assert.AreEqual(player2.Life, 20);
        }
        [TestMethod]
        public void Game_AttackPlayer_DeclareBlocker_Trample()
        {
            #region Begin Game
            ActiveGame game = new ActiveGame();
            List<PendingActionEventArgs> pendingActionsReturned = new List<PendingActionEventArgs>();
            game.OnPendingAction += delegate (object sender, EventArgs e) { pendingActionsReturned.Add((PendingActionEventArgs)e); };

            string player1SocketId = "p1";
            Player player1 = new Player() { SocketId = player1SocketId, Name = "Player 1" };
            game.Add(player1, Card_Mocker.MockDeck_TrampleCreaturesAndLand());

            string player2SocketId = "p2";
            Player player2 = new Player() { SocketId = player2SocketId, Name = "Player 2" };
            game.Add(player2, Card_Mocker.MockDeck_CreaturesAndLand());

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
            #region Player 1
            #region Play Land
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells1 = game.GetPlayerHand(player1.Id).Spells;
            Spell land1 = spells1.FirstOrDefault(o => o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = land1.CardId });
            #endregion
            #region Tap Land For Mana
            Guid landInBattleFieldId1 = player1.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse1 = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId1 });
            game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse1.Abilities[0].Id, CardId = activateResponse1.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell1 = spells1.FirstOrDefault(o => !o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player1.Id, SpellId = creatureSpell1.CardId });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            #endregion
            #endregion
            #region Player 2
            #region Play Land
            Game_Helper.ProcessToPhase(player2.Id, GamePhases.PreCombat_Main, ref game);
            List<Spell> spells2 = game.GetPlayerHand(player2.Id).Spells;
            Spell land2 = spells2.FirstOrDefault(o => o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player2.Id, SpellId = land2.CardId });
            #endregion
            #region Tap Land For Mana
            Guid landInBattleFieldId2 = player2.Battlefield.FilteredCards(o => o.HasType(CardType.Land))[0].Id;
            ActivateCardResponse activateResponse2 = game.ActivateCard(new ActivateCardRequest() { CardId = landInBattleFieldId2 });
            game.SelectAbility(new SelectAbilityRequest() { AbilityId = activateResponse2.Abilities[0].Id, CardId = activateResponse2.CardId });
            #endregion
            #region Cast Creature
            Spell creatureSpell2 = spells2.FirstOrDefault(o => !o.IsLand);
            game.CastSpell(new CastSpellRequest() { PlayerId = player2.Id, SpellId = creatureSpell2.CardId });
            game.ProcessStack(player1.Id);
            game.ProcessStack(player2.Id);
            #endregion
            #endregion
            #region Declare Attackers
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_DeclareAttackers, ref game);
            game.DeclareAttacker(new DeclareAttackerRequest() { AttackerId = creatureSpell1.CardId, Target = new MTG.Model.Objects.AttackableTarget() { AttackableType = AttackableType.Player, Id = player2.Id } });
            #endregion
            game.DeclareBlocker(new DeclareBlockerRequest() { AttackerId = creatureSpell1.CardId, BlockerId = creatureSpell2.CardId });
            Assert.AreEqual(player2.Life, 20);
            Game_Helper.ProcessToPhase(player1.Id, GamePhases.Combat_Ending, ref game);
            Card defendingCreature = game.Players.First(o => o.Id == player2.Id).FindCard(creatureSpell2.CardId);
            Card attackingCreature = game.Players.First(o => o.Id == player1.Id).FindCard(creatureSpell1.CardId);
            int attackingCreatureDamageTaken = 0;
            foreach (int damage in attackingCreature.Damage)
                attackingCreatureDamageTaken += damage;
            Assert.IsTrue(game.Players.First(o => o.Id == player2.Id).Graveyard.Find(defendingCreature.Id) != null);
            Assert.AreEqual(attackingCreatureDamageTaken, defendingCreature.Power);
            Assert.AreEqual(player2.Life, 20 - (attackingCreature.Power - defendingCreature.Toughness));
        }
    }
}