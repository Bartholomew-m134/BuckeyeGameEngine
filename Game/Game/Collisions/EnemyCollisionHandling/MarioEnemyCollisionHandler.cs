using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Game.Mario.MarioStates;
using Game.Utilities;
using Game.Enemies.GoombaClasses.GoombaStates;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class MarioEnemyCollisionHandler
    {
        private IMario mario;
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        public MarioEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IMario)
            {
                mario = (IMario)collision.GameObjectA;
                enemy = (IEnemy)collision.GameObjectB;
            }
            else
            {
                mario = (IMario)collision.GameObjectB;
                enemy = (IEnemy)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            HandleScore();
            if (!(mario.MarioState is DeadMarioState) && !mario.IsStarMario() && enemy is GreenKoopa && ((GreenKoopa)enemy).IsHit)
            {
                WeaponizedKoopa();
            }
            else if (!mario.IsStarMario() && side is TopSideCollision && !enemy.IsFlipped)
            {
                MarioEnemyTopSide();
            }
                else if (!mario.IsStarMario() && !mario.IsHurt() && enemy.CanDealDamage)
            {
                collision.ResolveOverlap(mario, side);
                mario.Damage();
            }
            else if (mario.IsStarMario())
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }

        public void WeaponizedKoopa()
        {
            collision.ResolveOverlap(mario, side);
            if (((GreenKoopa)enemy).state is GreenKoopaEmergingFromShellState)
                ((GreenKoopa)enemy).state = new GreenKoopaHidingInShellState((GreenKoopa)enemy);
            if (side is LeftSideCollision && enemy.Physics.Velocity.X == 0)
            {
                ((GreenKoopa)enemy).IsWeaponized = true;
                enemy.Physics.Velocity = new Vector2(11, enemy.Physics.Velocity.Y);
            }
            else if (side is RightSideCollision && enemy.Physics.Velocity.X == 0)
            {
                ((GreenKoopa)enemy).IsWeaponized = true;
                enemy.Physics.Velocity = new Vector2(-11, enemy.Physics.Velocity.Y);
            }
            else if (side is TopSideCollision)
            {
                ((GreenKoopa)enemy).IsWeaponized = false;
                enemy.Physics.ResetPhysics();
                mario.Physics.Velocity = new Vector2(mario.Physics.Velocity.X, -2);
                mario.Physics.Acceleration = new Vector2(mario.Physics.Acceleration.X, 1);
            }
            else if (enemy.Physics.Velocity.X > 0)
            {
                enemy.Physics.Velocity = new Vector2(-11, enemy.Physics.Velocity.Y);
                mario.Damage();
            }
            else if (enemy.Physics.Velocity.X < 0)
            {
                enemy.Physics.Velocity = new Vector2(11, enemy.Physics.Velocity.Y);
                mario.Damage();
            }
        }

        private void MarioEnemyTopSide()
        {
            collision.ResolveOverlap(mario, side);
            enemy.CanDealDamage = false;
            enemy.Hit();

            mario.Physics.Velocity = new Vector2(mario.Physics.Velocity.X, -2);
            mario.Physics.Acceleration = new Vector2(mario.Physics.Acceleration.X, 1);
        }

        private void HandleScore()
        {
            if (enemy is Goomba && !(mario.MarioState is DeadMarioState) && side is TopSideCollision && !(mario is HurtMario) && !(mario is GrowMario) && !(mario is StarMario))
            {
                if (!(((Goomba)enemy).state is GoombaFlippedState) && !(((Goomba)enemy).state is GoombaSmashedState))
                {
                    ScoreManager.IncreaseScore(100);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
            if (enemy is GreenKoopa && !(mario.MarioState is DeadMarioState) && side is TopSideCollision && !(mario is HurtMario) && !(mario is GrowMario) && !(mario is StarMario))
            {
                if(!(((GreenKoopa)enemy).state is GreenKoopaEmergingFromShellState) && !(((GreenKoopa)enemy).state is GreenKoopaHidingInShellState)){
                    ScoreManager.IncreaseScore(100);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
            if (mario is StarMario && enemy is Goomba){
                if (((Goomba)enemy).state is GoombaWalkingLeftState || ((Goomba)enemy).state is GoombaWalkingRightState)
                {
                    ScoreManager.IncreaseScore(100);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
            if (mario is StarMario && enemy is GreenKoopa)
            {
                if (((GreenKoopa)enemy).state is GreenKoopaWalkingLeftState || ((GreenKoopa)enemy).state is GreenKoopaWalkingRightState)
                {
                    ScoreManager.IncreaseScore(200);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
        }
    }
}
