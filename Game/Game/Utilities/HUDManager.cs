using Game.Interfaces;
using Game.Items.ItemSprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class HUDManager
    {
        private static SpriteFont hudFont = SpriteFactories.BackgroundElementsSpriteFactory.CreateHUDFont();
        private static ISprite coin= (CoinSprite)SpriteFactories.ItemsSpriteFactory.CreateCoinSprite();
        public static int scoreToPrint;
        public static int coinsToPrint;
        public static int livesToPrint;
        public static int timeToPrint = 400;
        private static int updateTimerCounter = 0;
        public static Vector2 marioHUDLocation = new Vector2(30, 0);
        public static Vector2 scoreHUDLocation = new Vector2(30, 25);
        public static Vector2 coinHUDLocation = new Vector2(210, 25);
        public static Vector2 coinSpriteHUDLocation = new Vector2(190, 39);
        public static Vector2 worldHUDLocation = new Vector2(410, 0);
        public static Vector2 timeStringHUDLocation = new Vector2(610, 0);
        public static Vector2 timeCounterStringHUDLocation = new Vector2(610, 25);
        public static Vector2 worldNumberStringHUDLocation = new Vector2(435, 25);
        private static string marioString = "MARIO";
        private static string worldString = "WORLD";
        private static string timeString = "TIME";
        private static string worldNumberString = "1-1";

        public static void UpdateHUDScore(int scoreToAdd)
        {
            scoreToPrint = scoreToAdd;
        }
        public static void UpdateHUDCoins(int coinsToAdd)
        {
            coinsToPrint += coinsToAdd;
        }
        public static void UpdateHUDTime()
        {
            timeToPrint -= 1;
        }
        public static void Update()
        {
            if (updateTimerCounter >=15)
            {
                UpdateHUDTime();
                updateTimerCounter = 0;
            }
            updateTimerCounter += 1;
            coin.Update();
            
        }
        public static void DrawHUD(SpriteBatch spriteBatch, ICamera camera)
        {
            string scoreString = scoreToPrint.ToString();
            string timeCounterString = timeToPrint.ToString();
            string coinString = "x" + coinsToPrint.ToString();

            coin.Draw(spriteBatch, coinSpriteHUDLocation);
            spriteBatch.Begin();
            spriteBatch.DrawString(hudFont, marioString, marioHUDLocation, Color.White);
            spriteBatch.DrawString(hudFont, scoreString, scoreHUDLocation, Color.White);
            spriteBatch.DrawString(hudFont, coinString, coinHUDLocation, Color.White);
            spriteBatch.DrawString(hudFont, worldString, worldHUDLocation, Color.White);
            spriteBatch.DrawString(hudFont, worldNumberString, worldNumberStringHUDLocation, Color.White);
            spriteBatch.DrawString(hudFont, timeString, timeStringHUDLocation, Color.White);
            spriteBatch.DrawString(hudFont, timeCounterString, timeCounterStringHUDLocation, Color.White);

            spriteBatch.End();

        }
    }
}
