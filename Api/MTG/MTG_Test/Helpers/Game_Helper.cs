using MTG.Enumerations;
using MTG.Model;
using System;

namespace MTG_Test.Helpers
{
    public static class Game_Helper
    {
        public static void ProcessToPhase(Guid playerId, GamePhases phase, ref ActiveGame game)
        {
            if (game.ActivePlayer.Id == playerId && game.ActivePhase == phase)
                return;
            else
            {
                game.EndCurrentPhase();
                ProcessToPhase(playerId, phase, ref game);
            }
        }
    }
}
