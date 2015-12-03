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
        private static IMusic overworld = new MarioOverworldTheme();
        private static IMusic starMan = new StarTheme();
        private static IMusic flagPoleVictory = new FlagPoleVictoryTheme();
        private static IMusic death = new DeathTheme();
        private static IMusic buckeyeOverworld = new BuckeyeOverworldTheme();
        private static IMusic carmen = new CarmenTheme();
        private static IMusic pacLevel = new PacManLevelTheme();
        private static IMusic pacDeath = new PacMarioDeadTheme();

        private static IMusic prePowerUpTheme;

        public static void PlayOverWorldTheme(){
            StopAllBackgroundThemes();
            if(HUDManager.RemainingTime() > SoundConstants.HURRYUPTIME)
                overworld = new MarioOverworldTheme();
            else
                overworld = new RushedOverworldTheme();
            overworld.PlayTheme();
        }

        public static void PlayStarTheme()
        {
            GetPreviousTheme();
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
        public static void PlayPacMarioDeathTheme()
        {
            StopAllBackgroundThemes();
            pacDeath = new PacMarioDeadTheme();
            pacDeath.PlayTheme();
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
            buckeyeOverworld.StopTheme();
            pacLevel.StopTheme();
            carmen.StopTheme();
        }

        public static void HurryTimeUpdate()
        {
            if (overworld.IsPlaying())
                PlayOverWorldTheme();
            else if (starMan.IsPlaying())
                PlayStarTheme();
        }

        public static void PlayBuckeyeOverworldTheme()
        {
            StopAllBackgroundThemes();
            buckeyeOverworld = new BuckeyeOverworldTheme();
            buckeyeOverworld.PlayTheme();
        }

        public static void PlayCarmenTheme()
        {
            StopAllBackgroundThemes();
            carmen = new CarmenTheme();
            carmen.PlayTheme();
        }

        public static void PlayPacManLevelTheme()
        {
            StopAllBackgroundThemes();
            pacLevel = new PacManLevelTheme();
            pacLevel.PlayTheme();
        }

        public static void ResetFromPowerUpTheme()
        {
            StopAllBackgroundThemes();
            prePowerUpTheme.PlayTheme();
        }

        private static void GetPreviousTheme()
        {
            if (overworld.IsPlaying())
                prePowerUpTheme = overworld;
            else if (flagPoleVictory.IsPlaying())
                prePowerUpTheme = flagPoleVictory;
            else if (buckeyeOverworld.IsPlaying())
                prePowerUpTheme = buckeyeOverworld;
            else if (pacLevel.IsPlaying())
                prePowerUpTheme = pacLevel;
        }
    }
}
