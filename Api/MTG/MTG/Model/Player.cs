using System;

namespace MTG.Model
{
    public class Player
    {
        public bool CheckLoseConditions()
        {
            /*
             * https://mtg.gamepedia.com/Ending_the_game
                104.3. There are several ways to lose the game.
                104.3a A player can concede the game at any time. A player who concedes leaves 
                        the game immediately. That player loses the game.
                104.3b If a player’s life total is 0 or less, that player loses the game the next 
                        time a player would receive priority. (This is a state-based action. See rule 704.)
                104.3c If a player is required to draw more cards than are left in their library, 
                        they draw the remaining cards and then lose the game the next time a player would 
                        receive priority. (This is a state-based action. See rule 704.)
                104.3d If a player has ten or more poison counters, that player loses the game the next 
                        time a player would receive priority. (This is a state-based action. See rule 704.)
                104.3e An effect may state that a player loses the game.
                104.3f If a player would both win and lose the game simultaneously, that player loses the 
                        game.
                104.3g In a multiplayer game between teams, a team loses the game if all players on that 
                        team have lost the game.
                104.3h In a multiplayer game using the limited range of influence option (see rule 801), 
                        an effect that states that a player wins the game instead causes all of that player’s 
                        opponents within the player’s range of influence to lose the game. This may not cause 
                        the game to end.
                104.3i In an Emperor game, a team loses the game if its emperor loses the game. 
                        (See rule 809.5.)
                104.3j In a Commander game, a player that’s been dealt 21 or more combat damage by the same 
                        commander over the course of the game loses the game. (This is a state-based action. 
                        See rule 704. See also rule 903.10.)
                104.3k In a tournament, a player may lose the game as a result of a penalty given by a judge. 
                        See rule 100.6.
             */
            throw new NotImplementedException();
        }
    }
}
