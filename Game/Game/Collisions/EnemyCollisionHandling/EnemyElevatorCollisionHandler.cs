using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Microsoft.Xna.Framework;
using Game.SoundEffects;
using Game.Utilities;
using Game.Utilities.Constants;


namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyElevatorCollisionHandler
    {
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        private IGameState gameState;

        public EnemyElevatorCollisionHandler(CollisionData collision, IGameState gameState)
        {
            this.collision = collision;
            this.gameState = gameState;

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
            Console.WriteLine(collision.CollisionSide);
            if (side is LeftSideCollision)
            {
                enemy.ShiftDirection();
            }
            else if (side is RightSideCollision)
            {
                enemy.ShiftDirection();
            }
        }
    }
}
