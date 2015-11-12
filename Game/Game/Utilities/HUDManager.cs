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

        public static void UpdateHUDScore(int scoreToAdd)
        {
            scoreToPrint = scoreToAdd;
        }
        public static void UpdateHUDCoins(int coinsToAdd)
        {
            coinsToPrint += coinsToAdd;
            if (coinsToPrint % HUDConstants.COINSPERLIFE== HUDConstants.ZEROREMAINDER){
                LifeManager.IncrementLives();
            }
        }
        public static int RemainingTime(){
            return timeToPrint;
        }
        public static void UpdateHUDTime()
        {
            timeToPrint -= HUDConstants.INCREMENTBYONE;
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
            string coinString = HUDConstants.XCOINCOUNTER + coinsToPrint.ToString();
            coin.Draw(spriteBatch, HUDConstants.COINSPRITEHUDLOCATION);
            spriteBatch.Begin();
            spriteBatch.DrawString(hudFont, HUDConstants.MARIOHUDSTRING, HUDConstants.MARIOHUDLOCATION, Color.White);
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
    }
}
