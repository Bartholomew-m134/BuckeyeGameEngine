using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Music
{
    public static class BackgroundThemeManager
    {
        private static IMusic overworld = new OverworldTheme();
        private static IMusic starMan = new StarTheme();
        private static IMusic flagPoleVictory = new FlagPoleVictoryTheme();
        private static IMusic death = new DeathTheme();

        public static void PlayOverWorldTheme(){
            starMan.StopTheme();
            flagPoleVictory.StopTheme();
            overworld.StopTheme();
            overworld = new OverworldTheme();
            overworld.PlayTheme();
        }

        public static void PlayStarTheme()
        {
            starMan.StopTheme();
            flagPoleVictory.StopTheme();
            overworld.StopTheme();
            starMan = new StarTheme();
            starMan.PlayTheme();
        }

        public static void PlayFlagPoleVictoryTheme()
        {
            starMan.StopTheme();
            flagPoleVictory.StopTheme();
            overworld.StopTheme();
            flagPoleVictory = new FlagPoleVictoryTheme();
            flagPoleVictory.PlayTheme();
        }

        public static void PlayDeathTheme()
        {
            starMan.StopTheme();
            flagPoleVictory.StopTheme();
            overworld.StopTheme();
            death = new DeathTheme();
            death.PlayTheme();
        }

        public static void StopAllBackgroundThemes()
        {
            starMan.StopTheme();
            flagPoleVictory.StopTheme();
            overworld.StopTheme();
        }
    }
}
