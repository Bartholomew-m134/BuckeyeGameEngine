using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.GameStates;
using Game.Music;

namespace Game.ProjectBuckeye
{
    public static class BuckeyeVictoryTransition
    {
        public static void TransitionToVictory(Game1 game)
        {
            int delay = 0;
            BackgroundThemeManager.PlayCarmenTheme();
            game.gameState = new VictoryScreenGameState(game);
            game.gameState.LoadContent();
        }
    }
}
