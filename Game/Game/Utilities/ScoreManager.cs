﻿using Game.Interfaces;
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
        private static int drawOnScreenTimer=0;
        private static int[] shellSequence;
        private static int[] stompSequence;
        private static int upwardDrawYModifier = 0;
        public static bool onStreak = false;
        
        public static void IncreaseScore(int value)
        {
            totalScore += value;
            HUDManager.UpdateHUDScore(totalScore);
            if (drawOnScreenTimer<10 && hasChanged && !onStreak){
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
            totalScore = 0;

        }
        public static void Update()
        {
            if(hasChanged && drawOnScreenTimer>=10){
                hasChanged = false;
                drawOnScreenTimer = 0;
            }

            if(hasChanged)
            drawOnScreenTimer++;

            if (upwardDrawYModifier >= 1)
            {
                upwardDrawYModifier = 0;
            }
            upwardDrawYModifier += 1;
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
            shellSequence = new int[8];
            shellSequence[0] = 500;
            shellSequence[1] = 800;
            shellSequence[2] = 1000;
            shellSequence[3] = 2000;
            shellSequence[4] = 4000;
            shellSequence[5] = 5000;
            shellSequence[6] = 8000;
            
            return shellSequence[shellSequenceIndex];
        }
        public static int HandleStompSequence(int shellSequenceIndex)
        {
            stompSequence = new int[11];
            stompSequence[0] = 100;
            stompSequence[1] = 200;
            stompSequence[2] = 400;
            stompSequence[3] = 500;
            stompSequence[4] = 800;
            stompSequence[5] = 1000;
            stompSequence[6] = 2000;
            stompSequence[7] = 4000;
            stompSequence[8] = 5000;
            stompSequence[9] = 8000;

            return stompSequence[shellSequenceIndex];
        }

        public static int HandleFlagPoleRange(int marioFootLocation)
        {
            if (marioFootLocation >= 272 && marioFootLocation < 315)
            {
                return 5000;
            }
            else if (marioFootLocation >= 315 && marioFootLocation < 336)
            {
                return 2000;
            }
            else if (marioFootLocation >= 336 && marioFootLocation < 368)
            {
                return 800;
            }
            else if (marioFootLocation >= 368 && marioFootLocation < 416)
            {
                return 400;
            }
            else
            {
                return 100;
            }
        }
    }
}
