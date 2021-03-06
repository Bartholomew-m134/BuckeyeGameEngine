﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Microsoft.Xna.Framework;
using Game.SoundEffects;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyPipeCollisionHandler
    {
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;

        public EnemyPipeCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            collision.ResolveOverlap(enemy, side);
            if (side is LeftSideCollision)
            {
                enemy.ShiftDirection();
                if (enemy is GreenKoopa && ((GreenKoopa)enemy).IsWeaponized)
                {
                    SoundEffectManager.EnemyFlippedEffect();
                    enemy.Physics.Velocity = new Vector2(-enemy.Physics.Velocity.X, enemy.Physics.Velocity.Y);
                }
            }
            else if (side is RightSideCollision)
            {
                enemy.ShiftDirection();
                if (enemy is GreenKoopa && ((GreenKoopa)enemy).IsWeaponized)
                {
                    SoundEffectManager.EnemyFlippedEffect();
                    enemy.Physics.Velocity = new Vector2(-enemy.Physics.Velocity.X, enemy.Physics.Velocity.Y);
                }
            }
        }
    }
}
