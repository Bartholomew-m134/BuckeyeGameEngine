using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;

namespace Game.SoundEffects
{
    public static class SoundEffectManager
    {
        private static ISoundEffect enemyFlipped;
        private static ISoundEffect fireBallThrowEffect;
        private static ISoundEffect smallMarioJumpEffect;
        private static ISoundEffect superMarioJumpEffect;
        private static ISoundEffect breakingBlockSoundEffect;
        private static ISoundEffect blockBumpedEffect;
        private static ISoundEffect powerUpAppearsEffect;
        private static ISoundEffect goombaHitEffect;
        private static ISoundEffect coinEffect;
        private static ISoundEffect oneUpEffect;
        private static ISoundEffect flagPoleEffect;
        private static ISoundEffect powerPlayerUpEffect;
        private static ISoundEffect shrinkingOrPipeEffect;
        private static ISoundEffect gameOverEffect;
        private static ISoundEffect pacMarioChompEffect;
        private static ISoundEffect eatGhostEffect;

        public static void EnemyFlippedEffect()
        {
            enemyFlipped = new EnemyFlippedEffect();
            enemyFlipped.Play();
        }

        public static void FireBallThrowEffect()
        {
            fireBallThrowEffect = new FireballEffect();
            fireBallThrowEffect.Play();
        }

        public static void SmallMarioJumpEffect()
        {
            smallMarioJumpEffect = new SmallMarioJumpEffect();
            smallMarioJumpEffect.Play();
        }

        public static void SuperMarioJumpEffect()
        {
            superMarioJumpEffect = new SuperMarioJumpEffect();
            superMarioJumpEffect.Play();
        }

        public static void BreakingBlockSoundEffect()
        {
            breakingBlockSoundEffect = new BrickBreakingEffect();
            breakingBlockSoundEffect.Play();
        }

        public static void BlockBumpedEffect()
        {
            blockBumpedEffect = new BlockBumpEffect();
            blockBumpedEffect.Play();
        }

        public static void PowerUpAppearsEffect()
        {
            powerUpAppearsEffect = new PowerUpAppearsEffect();
            powerUpAppearsEffect.Play();
        }

        public static void GoombaHitEffect()
        {
            goombaHitEffect = new GoombaStompedEffect();
            goombaHitEffect.Play();
        }

        public static void CoinEffect()
        {
            coinEffect = new CoinEffect();
            coinEffect.Play();
        }

        public static void OneUpEffect()
        {
            oneUpEffect = new OneUpEffect();
            oneUpEffect.Play();
        }

        public static void FlagPoleEffect()
        {
            flagPoleEffect = new FlagPoleMovingEffect();
            flagPoleEffect.Play();
        }

        public static void PowerPlayerUpEffect()
        {
            powerPlayerUpEffect = new PowerPlayerUpEffect();
            powerPlayerUpEffect.Play();
        }

        public static void ShrinkingOrPipeEffect()
        {
            shrinkingOrPipeEffect = new ShrinkingOrPipeEffect();
            shrinkingOrPipeEffect.Play();
        }

        public static void GameOverEffect()
        {
            gameOverEffect = new GameOverEffect();
            gameOverEffect.Play();
        }
        public static void PacMarioChompEffect()
        {
            pacMarioChompEffect = new PacMarioChompEffect();
            pacMarioChompEffect.Play();
        }
        public static void EatGhostEffect()
        {
            eatGhostEffect = new EatGhostEffect();
            eatGhostEffect.Play();
        }
    }
}
