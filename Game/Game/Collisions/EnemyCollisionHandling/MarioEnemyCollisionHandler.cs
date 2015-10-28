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
            if (!(mario.MarioState is DeadMarioState))
            {
                if (!mario.IsStar() && enemy is GreenKoopa && ((GreenKoopa)enemy).IsHit)
                {
                WeaponizedKoopa();
            }
            else if (!mario.IsStar() && side is TopSideCollision && !enemy.IsFlipped)
            {
                MarioEnemyTopSide();
            }
                else if (!mario.IsStar() && enemy.CanDealDamage)
            {
                collision.ResolveOverlap(mario, side);
                mario.Damage();
            }
            else if (mario.IsStar())
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }
        }

        public void WeaponizedKoopa()
        {
            collision.ResolveOverlap(mario, side);
            if (((GreenKoopa)enemy).state is GreenKoopaEmergingFromShellState)
            {
                ((GreenKoopa)enemy).state = new GreenKoopaHidingInShellState((GreenKoopa)enemy);
            }
            if (((GreenKoopa)enemy).IsHit && side is LeftSideCollision && enemy.Physics.Velocity.X == 0)
            {
                ((GreenKoopa)enemy).IsWeaponized = true;
                enemy.Physics.Velocity = new Vector2(11, enemy.Physics.Velocity.Y);
            }
            else if (((GreenKoopa)enemy).IsHit && side is RightSideCollision && enemy.Physics.Velocity.X == 0)
            {
                ((GreenKoopa)enemy).IsWeaponized = true;
                enemy.Physics.Velocity = new Vector2(-11, enemy.Physics.Velocity.Y);
            }
            else if (((GreenKoopa)enemy).IsHit && side is TopSideCollision)
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

        public void MarioEnemyTopSide()
        {
            collision.ResolveOverlap(mario, side);
            enemy.CanDealDamage = false;
            enemy.Hit();

            mario.Physics.Velocity = new Vector2(mario.Physics.Velocity.X, -2);
            mario.Physics.Acceleration = new Vector2(mario.Physics.Acceleration.X, 1);
        }
    }
}
