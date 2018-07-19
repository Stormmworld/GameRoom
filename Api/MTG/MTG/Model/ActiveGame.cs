using MTG.Enumerations;
using MTG.Model.Game;
using MTG.Model.Objects;
using MTG.Model.Zones;
using System;
using System.Collections.Generic;

namespace MTG.Model
{
    public class ActiveGame
    {
        #region Properties
        public int ActivePlayerIndex { get; set; }
        public GamePhases ActivePhase { get; set; }
        public Ante Ante { get; set; }
        public int DrawExtraCards
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public Exile Exile { get; set; }
        public GameType GameType { get; private set; }
        public GamePhases OverrideNextPhase { get; set; }
        public List<Player> Players { get; set; }
        public List<GamePhases> SkipPhases { get; set; }
        public Stack Stack { get; set; }
        public List<UpkeepRequirement> UpkeepRequirements { get; set; }
        #endregion

        #region Constructors
        public ActiveGame()
        {
            ActivePlayerIndex = 0;
            Ante = new Ante();
            Exile = new Exile();
            Players = new List<Player>();
            Stack = new Stack();
            OverrideNextPhase = GamePhases.None;
        }
        #endregion

        #region Methods
        public void AddToStack(StackEntry stackEntry)
        {
            throw new NotImplementedException();
        }
        public void EmptyManaPools()
        {
            foreach (Player player in Players)
                player.EmptyManaPool();
        }
        public void ProcessPhase()
        {
            /*
             * https://mtg.gamepedia.com/Turn_structure
                500.1. A turn consists of five phases, in this order: beginning, precombat main, combat, postcombat main, 
                        and ending. Each of these phases takes place every turn, even if nothing happens during the phase. 
                        The beginning, combat, and ending phases are further broken down into steps, which proceed in order.
                500.2. A phase or step in which players receive priority ends when the stack is empty and all players pass 
                        in succession. Simply having the stack become empty doesn’t cause such a phase or step to end; all 
                        players have to pass in succession with the stack empty. Because of this, each player gets a chance 
                        to add new things to the stack before that phase or step ends.
                500.3. A step in which no players receive priority ends when all specified actions that take place during 
                        that step are completed. The only such steps are the untap step (see rule 502) and certain cleanup 
                        steps (see rule 514).
                500.4. When a step or phase ends, any unused mana left in a player’s mana pool empties. This turn-based 
                        action doesn’t use the stack.
                500.5. When a phase or step ends, any effects scheduled to last “until end of” that phase or step expire. 
                        When a phase or step begins, any effects scheduled to last “until” that phase or step expire. Effects 
                        that last “until end of combat” expire at the end of the combat phase, not at the beginning of the 
                        end of combat step. Effects that last “until end of turn” are subject to special rules; see rule 514.2.
                500.6. When a phase or step begins, any abilities that trigger “at the beginning of” that phase or step 
                        trigger. They are put on the stack the next time a player would receive priority. (See rule 116, 
                        “Timing and Priority.”)
                500.7. Some effects can give a player extra turns. They do this by adding the turns directly after the 
                        specified turn. If a player is given multiple extra turns, the extra turns are added one at a time. 
                        If multiple players are given extra turns, the extra turns are added one at a time, in APNAP order 
                        (see rule 101.4). The most recently created turn will be taken first.
                500.8. Some effects can add phases to a turn. They do this by adding the phases directly after the 
                        specified phase. If multiple extra phases are created after the same phase, the most recently 
                        created phase will occur first.
                500.9. Some effects can add steps to a phase. They do this by adding the steps directly after a specified 
                        step or directly before a specified step. If multiple extra steps are created after the same step, 
                        the most recently created step will occur first.
                500.10. Some effects can cause a step, phase, or turn to be skipped. To skip a step, phase, or turn is to 
                        proceed past it as though it didn’t exist. See rule 614.10.
                500.11. No game events can occur between turns, phases, or steps.
             */
            if (ActivePhase == GamePhases.None)//beginning of game scenario
                ActivePhase = GamePhases.Beginning_Untap;
            switch (ActivePhase)
            {
                case GamePhases.Beginning_Untap:
                    Phases.BegginingPhase_UntapStep(this);
                    break;
                case GamePhases.Beginning_Upkeep:
                    Phases.BegginingPhase_UpkeepStep(this);
                    break;
                case GamePhases.Beginning_Draw:
                    Phases.BegginingPhase_UpkeepStep_End(this);
                    Phases.BegginingPhase_DrawStep(this);
                    break;
                case GamePhases.PreCombat_Main:
                    Phases.PreCombatMainPhase(this);
                    break;
                case GamePhases.Combat_Beginning:
                    Phases.CombatPhase_BeginningStep(this);
                    break;
                case GamePhases.Combat_DeclareAttackers:
                    Phases.CombatPhase_DeclareAttackersStep(this);
                    break;
                case GamePhases.Combat_DeclareDefenders:
                    Phases.CombatPhase_DeclareBlockersStep(this);
                    break;
                case GamePhases.Combat_Damage:
                    Phases.CombatPhase_CombatDamageStep(this);
                    break;
                case GamePhases.Combat_Ending:
                    Phases.CombatPhase_EndStep(this);
                    break;
                case GamePhases.PostCombat_Main:
                    Phases.PostCombatMainPhase(this);
                    break;
                case GamePhases.Ending_End:
                    Phases.EndingPhase_EndStep(this);
                    break;
                case GamePhases.Ending_Cleanup:
                    Phases.EndingPhase_CleanupStep(this);
                    break;
            }
        }
        public void SetGameType(GameType gameType)
        {
            //Apply any game type specific settings
            GameType = gameType;
            switch (GameType)
            {
                case GameType.Melee:
                    break;
            }
        }
        public void RestartGame()
        {
            //reset all remaining players to new game
            throw new NotImplementedException();
        }
        #endregion
    }
}