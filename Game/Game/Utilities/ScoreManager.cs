using Game.Interfaces;
using Game.Utilities.Constants;
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
        public static int totalScore;
        public static Vector2 location;
        public static Game1 game;
        private static SpriteFont scoreFont;
        public static bool flagTopBeenHit = false;
        private static bool hasChanged = false;
        private static int currentScoreToDraw;
        private static int drawOnScreenTimer = ScoreManagerConstants.RESETTOZERO;
        private static int upwardDrawYModifier = ScoreManagerConstants.RESETTOZERO;
        public static bool onStreak = false;
        
        public static void IncreaseScore(int value)
        {
            totalScore += value;
            HUDManager.UpdateHUDScore(totalScore);
            if (drawOnScreenTimer < ScoreManagerConstants.UPDATEDELAY && hasChanged && !onStreak)
            {
                currentScoreToDraw += value;
            }
            else
            {
                currentScoreToDraw = value;
            }
            hasChanged = true;
            if (scoreFont == null)
                scoreFont = SpriteFactories.BackgroundElementsSpriteFactory.CreateScoreFont();
        }
        public static void ResetScore()
        {
            totalScore = ScoreManagerConstants.RESETTOZERO;

        }
        public static void Update()
        {
            if(hasChanged && drawOnScreenTimer>=ScoreManagerConstants.UPDATEDELAY){
                hasChanged = false;
                drawOnScreenTimer = ScoreManagerConstants.RESETTOZERO;
            }

            if(hasChanged)
            drawOnScreenTimer++;

            if (upwardDrawYModifier >= ScoreManagerConstants.INCREMENTBYONE)
            {
                upwardDrawYModifier = ScoreManagerConstants.RESETTOZERO;
            }
            upwardDrawYModifier += ScoreManagerConstants.INCREMENTBYONE;
        }
        public static void DrawScore(SpriteBatch spriteBatch, ICamera camera)
        {
            string scoreString = currentScoreToDraw.ToString();
            location.Y -= upwardDrawYModifier;
            if(hasChanged){
                spriteBatch.Begin();
                spriteBatch.DrawString(scoreFont, scoreString, camera.GetAdjustedPosition(location), Color.White);
                spriteBatch.End();
            }
        }

        public static int HandleShellSequence(int shellSequenceIndex)
        {
            return ScoreManagerConstants.SHELLSEQUENCE[shellSequenceIndex];
        }
        public static int HandleStompSequence(int stompSequenceIndex)
        {
            return ScoreManagerConstants.STOMPSEQUENCE[stompSequenceIndex];
        }

        public static int HandleFlagPoleRange(int marioFootLocation)
        {
            if (marioFootLocation >= ScoreManagerConstants.ZONEONEYCOORDINATE && marioFootLocation < ScoreManagerConstants.ZONETWOYCOORDINATE)
            {
                return ScoreManagerConstants.ZONEONESCORE;
            }
            else if (marioFootLocation >= ScoreManagerConstants.ZONETWOYCOORDINATE && marioFootLocation < ScoreManagerConstants.ZONETHREEYCOORDINATE)
            {
                return ScoreManagerConstants.ZONETWOSCORE;
            }
            else if (marioFootLocation >= ScoreManagerConstants.ZONETHREEYCOORDINATE && marioFootLocation < ScoreManagerConstants.ZONEFOURYCOORDINATE)
            {
                return ScoreManagerConstants.ZONETHREESCORE;
            }
            else if (marioFootLocation >= ScoreManagerConstants.ZONEFOURYCOORDINATE && marioFootLocation < ScoreManagerConstants.ZONEFIVEYCOORDINATE)
            {
                return ScoreManagerConstants.ZONEFOURSCORE;
            }
            else
            {
                return ScoreManagerConstants.ZONEFIVESCORE;
            }
        }
    }
}
