using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Microsoft.Xna.Framework;
using Game.Blocks;
using Game.Enemies.GoombaClasses;
using Game.Enemies.GoombaClasses.GoombaStates;
using Game.Utilities;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.SoundEffects;
using Game.Utilities.Constants;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyBlockCollisionHandler
    {
        private IEnemy enemy;
        IBlock block;
        private ICollisionSide side;
        private CollisionData collision;

        public EnemyBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
                block = (IBlock)collision.GameObjectB;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                block = (IBlock)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            HandleScore();
            if (!enemy.IsFlipped)
                collision.ResolveOverlap(enemy, side);
            if (side is LeftSideCollision)
            {
                enemy.ShiftDirection();
                if (enemy is GreenKoopa && ((GreenKoopa)enemy).IsWeaponized)
                {
                    SoundEffectManager.EnemyFlippedEffect();
                    enemy.Physics.Velocity = new Vector2(-11, enemy.Physics.Velocity.Y);
                }
            }
            else if (side is RightSideCollision)
            {
                enemy.ShiftDirection();
                if (enemy is GreenKoopa && ((GreenKoopa)enemy).IsWeaponized)
                {
                    SoundEffectManager.EnemyFlippedEffect();
                    enemy.Physics.Velocity = new Vector2(11, enemy.Physics.Velocity.Y);
                }
            }
            else if (side is TopSideCollision && ((Block)block).IsBumped)
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }
        private void HandleScore()
        {
            if(((Block)block).IsBumped && enemy is Goomba && side is TopSideCollision){
                if (((Goomba)enemy).state is GoombaWalkingLeftState || ((Goomba)enemy).state is GoombaWalkingRightState)
                {
                    ScoreManager.IncreaseScore(ScoreManagerConstants.ONEHUNDREDPOINTS);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }

            if (((Block)block).IsBumped && enemy is GreenKoopa && side is TopSideCollision)
            {
                if (((GreenKoopa)enemy).state is GreenKoopaWalkingLeftState || ((GreenKoopa)enemy).state is GreenKoopaWalkingRightState)
                {
                    ScoreManager.IncreaseScore(ScoreManagerConstants.ONEHUNDREDPOINTS);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
        }
    }
}
