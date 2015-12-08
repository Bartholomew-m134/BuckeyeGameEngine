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
        public static Vector2 location;
        public static int stompStreak;
        public static int shellStreak;

        private static int totalScore;
        private static SpriteFont scoreFont;
        private static bool flagTopBeenHit = false;
        private static bool hasChanged = false;
        private static int currentScoreToDraw;
        private static int drawOnScreenTimer = ScoreManagerConstants.RESETTOZERO;
        private static int upwardDrawYModifier = ScoreManagerConstants.RESETTOZERO;

        
        public static void IncreaseScore(int value)
        {
            if (!(value == ScoreManagerConstants.AWARDONELIFE))
            {
                totalScore += value;
                HUDManager.UpdateHUDScore(totalScore);
                if (drawOnScreenTimer < ScoreManagerConstants.UPDATEDELAY && hasChanged && (OnShellStreak() == false) && (OnStompStreak() == false))
                    currentScoreToDraw += value;
                else
                    currentScoreToDraw = value;
                hasChanged = true;
                if (scoreFont == null)
                    scoreFont = SpriteFactories.BackgroundElementsSpriteFactory.CreateScoreFont();
            }
            else
                LifeManager.IncrementLives();
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
                upwardDrawYModifier = ScoreManagerConstants.RESETTOZERO; 
            upwardDrawYModifier += ScoreManagerConstants.INCREMENTBYONE;
        }
        public static void DrawScore(SpriteBatch spriteBatch, ICamera camera)
        {
            string scoreString = currentScoreToDraw.ToString();
            location.Y -= upwardDrawYModifier;
            if (hasChanged && !(HUDManager.CurrentGameState() == HUDConstants.PACMARIOHUDSTRING) && !(HUDManager.CurrentGameState() == HUDConstants.BRICKBREAKERHUDSTRING))
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
                spriteBatch.DrawString(scoreFont, scoreString, camera.GetAdjustedPosition(location), Color.White);
                spriteBatch.End();
            }
        }

        public static int HandleShellSequence(int shellSequenceIndex)
        {
            if (shellSequenceIndex > ScoreManagerConstants.SHELLSEQUENCEMAXINDEX)
            {
                ScoreManager.shellStreak = ScoreManagerConstants.RESETTOZERO;
                return ScoreManagerConstants.SHELLSEQUENCE[shellStreak];
            }
            else
                return ScoreManagerConstants.SHELLSEQUENCE[shellSequenceIndex];
        }
        public static int HandleStompSequence(int stompSequenceIndex)
        {
            if (stompSequenceIndex > ScoreManagerConstants.STOMPSEQUENCEMAXINDEX)
            {
                stompStreak = ScoreManagerConstants.RESETTOZERO;
                return ScoreManagerConstants.STOMPSEQUENCE[stompStreak];
            }
            else
                return ScoreManagerConstants.STOMPSEQUENCE[stompSequenceIndex];
        }

        public static void HandleRemainingTime()
        {
            ScoreManager.IncreaseScore(HUDManager.RemainingTime() * ScoreManagerConstants.POINTSPERREMAININGSECOND);
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

        public static bool FlagTopBeenHit
        {
            get { return flagTopBeenHit; }
            set { flagTopBeenHit = value; }
        }

        public static bool OnStompStreak()
        {
            return (stompStreak > ScoreManagerConstants.MINIMUMSTREAKINDEX);
        }
        public static bool OnShellStreak()
        {
            return (shellStreak > ScoreManagerConstants.MINIMUMSTREAKINDEX);
        }
    }
}
