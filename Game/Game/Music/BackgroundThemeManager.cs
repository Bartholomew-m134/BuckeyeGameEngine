using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.Music
{
    public static class BackgroundThemeManager
    {
        private static IMusic overworld = new OverworldTheme();
        private static IMusic starMan = new StarTheme();
        private static IMusic flagPoleVictory = new FlagPoleVictoryTheme();
        private static IMusic death = new DeathTheme();

        public static void PlayOverWorldTheme(){
            StopAllBackgroundThemes();
            if(HUDManager.RemainingTime() > SoundConstants.HURRYUPTIME)
                overworld = new OverworldTheme();
            else
                overworld = new RushedOverworldTheme();
            overworld.PlayTheme();
        }

        public static void PlayStarTheme()
        {
            StopAllBackgroundThemes();
            if (HUDManager.RemainingTime() > SoundConstants.HURRYUPTIME)
                starMan = new StarTheme();
            else
                starMan = new RushedStarTheme();
            starMan.PlayTheme();
        }

        public static void PlayFlagPoleVictoryTheme()
        {
            StopAllBackgroundThemes();
            flagPoleVictory = new FlagPoleVictoryTheme();
            flagPoleVictory.PlayTheme();
        }

        public static void PlayDeathTheme()
        {
            StopAllBackgroundThemes();
            death = new DeathTheme();
            death.PlayTheme();
        }

        public static void StopAllBackgroundThemes()
        {
            starMan.StopTheme();
            flagPoleVictory.StopTheme();
            overworld.StopTheme();
            death.StopTheme();
        }

        public static void HurryTimeUpdate()
        {
            if (overworld.IsPlaying())
                PlayOverWorldTheme();
            else if (starMan.IsPlaying())
                PlayStarTheme();
        }
    }
}
