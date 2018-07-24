using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Model.Game
{
    public class EndOfGame
    {
        public void CheckDrawCondition()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.4. There are several ways for the game to be a draw.
                104.4a If all the players remaining in a game lose simultaneously, the game is a draw.
                104.4b If a game that’s not using the limited range of influence option (including a two-player game) 
                        somehow enters a “loop” of mandatory actions, repeating a sequence of events with no way to stop, 
                        the game is a draw. Loops that contain an optional action don’t result in a draw.
                104.4c An effect may state that the game is a draw.
                104.4d In a multiplayer game between teams, the game is a draw if all remaining teams lose simultaneously.
                104.4e In a multiplayer game using the limited range of influence option, the effect of a spell or ability 
                        that states that the game is a draw causes the game to be a draw for that spell or ability’s 
                        controller and all players within their range of influence. Only those players leave the game; 
                        the game continues for all other players.
                104.4f In a multiplayer game using the limited range of influence option, if the game somehow enters a “loop” 
                        of mandatory actions, repeating a sequence of events with no way to stop, the game is a draw for 
                        each player who controls an object that’s involved in that loop, as well as for each player within 
                        the range of influence of any of those players. Only those players leave the game; the game 
                        continues for all other players.
                104.4g In a multiplayer game between teams, the game is a draw for a team if the game is a draw for all 
                        remaining players on that team.
                104.4h In the Emperor variant, the game is a draw for a team if the game is a draw for its emperor. 
                        (See rule 809.5.)
                104.4i In a tournament, all players in the game may agree to an intentional draw. See rule 100.6.
                104.5. If a player loses the game, that player leaves the game. If the game is a draw for a player, 
                        that player leaves the game. The multiplayer rules handle what happens when a player leaves 
                        the game; see rule 800.4.
                104.6. One card (Karn Liberated) restarts the game. All players still in the game when it restarts 
                        then immediately begin a new game. See rule 718, “Restarting the Game.”
             */
            throw new NotImplementedException("EndOfGame.CheckDrawCondition");
        }
        public void CheckEndGameCondition()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.1. A game ends immediately when a player wins, when the game is a draw, 
                        or when the game is restarted.
                104.2. There are several ways to win the game.
                104.2a A player still in the game wins the game if that player’s opponents 
                        have all left the game. This happens immediately and overrides all 
                        effects that would preclude that player from winning the game.
                104.2b An effect may state that a player wins the game.
                104.2c In a multiplayer game between teams, a team with at least one player
                        still in the game wins the game if all other teams have left the game. 
                        Each player on the winning team wins the game, even if one or more of 
                        those players had previously lost that game.
                104.2d In an Emperor game, a team wins the game if its emperor wins the game. 
                        (See rule 809.5.)
             */
            throw new NotImplementedException("EndOfGame.CheckEndGameCondition");
        }
        public void CheckPlayerLoseCondition()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.5. If a player loses the game, that player leaves the game. If the game is a draw for a player, 
                        that player leaves the game. The multiplayer rules handle what happens when a player leaves 
                        the game; see rule 800.4.
             */
            throw new NotImplementedException("EndOfGame.CheckPlayerLoseCondition");
        }
        public void CheckRestartGameCondition()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.6. One card (Karn Liberated) restarts the game. All players still in the game when it restarts 
                        then immediately begin a new game. See rule 718, “Restarting the Game.”
             */
            throw new NotImplementedException("EndOfGame.CheckRestartGameCondition");
        }
    }
}
