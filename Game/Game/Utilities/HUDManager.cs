using Game.Interfaces;
using Game.Items.ItemSprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.Music;
using Game.SoundEffects;

namespace Game.Utilities
{
    public static class HUDManager
    {
        private static SpriteFont hudFont = SpriteFactories.MenuSpriteFactory.CreateHUDFont();
        private static ISprite coin = SpriteFactories.ItemsSpriteFactory.CreateCoinSprite();
        private static int scoreToPrint;
        private static int coinsToPrint;
        private static int updateTimerCounter = HUDConstants.RESETUPDATEDELAYCOUNTER;
        private static int timeToPrint = HUDConstants.STARTINGTIME;
        private static string marioStringToPrint = HUDConstants.MARIOHUDSTRING;

        public static void UpdateHUDScore(int scoreToAdd)
        {
            scoreToPrint = scoreToAdd;
        }
        public static void UpdateHUDCoins(int coinsToAdd)
        {
            coinsToPrint += coinsToAdd;
            if (coinsToPrint % HUDConstants.COINSPERLIFE  == 0 && !(coinsToPrint == 0))
            {
                LifeManager.IncrementLives();
                if (marioStringToPrint == HUDConstants.MARIOHUDSTRING)
                    SoundEffectManager.OneUpEffect();
                else
                    SoundEffectManager.PacExtraLifeEffect();
            }
        }
        public static int RemainingTime(){
            return timeToPrint;
        }
        public static void UpdateHUDTime()
        {
            if (HUDManager.RemainingTime() == SoundConstants.HURRYUPTIME)
                BackgroundThemeManager.HurryTimeUpdate();
            timeToPrint -= HUDConstants.INCREMENTBYONE;
        }
        public static void UpdateHUDMarioString(string marioString)
        {
            marioStringToPrint = marioString;
        }
        public static string CurrentGameState()
        {
            return marioStringToPrint;
        }
        public static int CurrentAmountOfCoins()
        {
            return coinsToPrint;
        }
        public static void Update()
        {
            if (updateTimerCounter >=HUDConstants.NUMBEROFUPDATESPERSECOND)
            {
                UpdateHUDTime();
                updateTimerCounter = HUDConstants.RESETUPDATEDELAYCOUNTER;
            }
            updateTimerCounter += HUDConstants.INCREMENTBYONE;
            coin.Update();
            
        }
        public static void DrawHUD(SpriteBatch spriteBatch)
        {
            string scoreString = scoreToPrint.ToString();
            string timeCounterString = timeToPrint.ToString();
            string coinString = HUDConstants.XCOINCOUNTER + (coinsToPrint % HUDConstants.COINSPERLIFE).ToString();
            coin.Draw(spriteBatch, HUDConstants.COINSPRITEHUDLOCATION);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.DrawString(hudFont, marioStringToPrint, HUDConstants.MARIOHUDLOCATION, Color.White);
            spriteBatch.DrawString(hudFont, scoreString, HUDConstants.SCOREHUDLOCATION, Color.White);
            spriteBatch.DrawString(hudFont, coinString, HUDConstants.COINHUDLOCATION, Color.White);
            spriteBatch.DrawString(hudFont, HUDConstants.WORLDHUDSTRING, HUDConstants.WORLDHUDLOCATION, Color.White);
            spriteBatch.DrawString(hudFont, HUDConstants.WORLDNUMBERHUDSTRING, HUDConstants.WORLDNUMBERHUDLOCATION, Color.White);
            spriteBatch.DrawString(hudFont, HUDConstants.TIMEHUDSTRING, HUDConstants.TIMESTRINGHUDLOCATION, Color.White);
            spriteBatch.DrawString(hudFont, timeCounterString, HUDConstants.TIMECOUNTERHUDLOCATION, Color.White);

            spriteBatch.End();

        }
        public static void SetToStartingTime()
        {
            timeToPrint = HUDConstants.STARTINGTIME;
        }

        public static void SetTimeToZero()
        {
            timeToPrint = HUDConstants.RESETTOZERO;
        }
        public static bool OutOfTime
        {
            get { return (timeToPrint<=0); }
        }

        public static void ResetCoins()
        {
            coinsToPrint = 0;
        }
    }
}
