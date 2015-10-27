using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Enemies.GoombaClasses;

namespace Game.Collisions.EnemyCollisionHandling
{
    class EnemyEnemyCollisionHandler
    {
        private CollisionData collision;
        private IEnemy enemyA;
        private IEnemy enemyB;
        private ICollisionSide side;

        public EnemyEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            enemyA = (IEnemy)collision.GameObjectA;
            enemyB = (IEnemy)collision.GameObjectB;
            side = (ICollisionSide)collision.CollisionSide;
        }

        private bool LeftOrRightCollision()
        {
            return (side is LeftSideCollision || side is RightSideCollision);
        }

        public void HandleCollision()
        {
            if (enemyA.IsHit == false && enemyB.IsHit == false && LeftOrRightCollision())
            {
                collision.ResolveOverlap(collision.GameObjectA, collision.CollisionSide);
                enemyA.ShiftDirection();
                enemyB.ShiftDirection();
            }
            else if (enemyA is GreenKoopa && ((GreenKoopa)enemyA).IsWeaponized)
            {
                enemyB.Flipped();
            }
            else if (enemyB is GreenKoopa && ((GreenKoopa)enemyB).IsWeaponized)
            {
                enemyA.Flipped();
            }
            else if (enemyA.IsHit)
            {
                collision.ResolveOverlap(collision.GameObjectA, collision.CollisionSide);

                enemyB.ShiftDirection();
            }
            else if (enemyB.IsHit)
            {
                collision.ResolveOverlap(collision.GameObjectA, collision.CollisionSide);
                enemyA.ShiftDirection();
            }
        }
    }
}
