﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.ProjectBuckeye.PlayerClasses;
using Game.ProjectBuckeye.EnemyClasses;
using Game.Interfaces;
using Game.Collisions;

namespace Game.ProjectBuckeye.Collision
{
    public class BuckeyeWolverineCollisionHandler
    {
        private IBuckeyePlayer player;
        private IWolverine enemy;
        private ICollisionSide side;
        private CollisionData collision;
        public BuckeyeWolverineCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IBuckeyePlayer)
            {
                player = (IBuckeyePlayer)collision.GameObjectA;
                enemy = (IWolverine)collision.GameObjectB;
            }
            else
            {
                player = (IBuckeyePlayer)collision.GameObjectB;
                enemy = (IWolverine)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            if (!player.IsDead)
            {
                collision.ResolveOverlap(player, side);
                if ((side is LeftSideCollision || side is RightSideCollision) && enemy.CanDealDamage)
                {
                    player.Damage();
                    enemy.ShiftDirection();
                }
                else if (side is TopSideCollision)
                {
                    enemy.Hit();
                }
            }
        }
    }
}