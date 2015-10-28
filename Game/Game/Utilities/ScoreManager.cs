using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class ScoreManager
    {
        public static int score;
        public static Vector2 location;
        public static Game1 game;
        private static SpriteFont scoreFont;
        private static  string scoreString;
        public static bool flagTopBeenHit = false;
        private static bool hasChanged = false;
        private static int currentScoreToDraw;
        private static int drawOnScreenTimer;
        
        public static void IncreaseScore(int value)
        {
            currentScoreToDraw = value;
            hasChanged = true;
            score+=value;
            if (scoreFont == null)
                scoreFont = SpriteFactories.BackgroundElementsSpriteFactory.CreateScoreFont();
            Console.WriteLine(score);
        }
        public static void ResetScore()
        {
            score = 0;

        }
        public static void Update()
        {
            if(hasChanged && drawOnScreenTimer>=10){
                hasChanged = false;
                drawOnScreenTimer = 0;
            }

            if(hasChanged)
            drawOnScreenTimer++;
        }
        public static void DrawScore(SpriteBatch spriteBatch)
        {
            scoreString = currentScoreToDraw.ToString();
            if(hasChanged){
                spriteBatch.Begin();
                spriteBatch.DrawString(scoreFont, scoreString, location, Color.White);
                spriteBatch.End();
            }
        }
    }
}
