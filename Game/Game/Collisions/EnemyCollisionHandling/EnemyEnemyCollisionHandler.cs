using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Enemies.GoombaClasses;
using Game.Utilities;

namespace Game.Collisions.EnemyCollisionHandling
{
    class EnemyEnemyCollisionHandler
    {
        private CollisionData collision;
        private IEnemy enemyA;
        private IEnemy enemyB;
        private ICollisionSide side;
        private int shellSequenceIndex;

        public EnemyEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            enemyA = (IEnemy)collision.GameObjectA;
            enemyB = (IEnemy)collision.GameObjectB;
            side = (ICollisionSide)collision.CollisionSide;
            shellSequenceIndex = 0;
        }

        private bool LeftOrRightCollision()
        {
            return (side is LeftSideCollision || side is RightSideCollision);
        }

        public void HandleCollision()
        {
            HandleScore();
            if (enemyA.IsHit == false && enemyB.IsHit == false && LeftOrRightCollision())
            {
                collision.ResolveOverlap(collision.GameObjectA, collision.CollisionSide);
                enemyA.ShiftDirection();
                enemyB.ShiftDirection();
            }
            else if (enemyA is GreenKoopa && ((GreenKoopa)enemyA).IsWeaponized)
            {
                enemyB.CanDealDamage = false;
                enemyB.Flipped();
            }
            else if (enemyB is GreenKoopa && ((GreenKoopa)enemyB).IsWeaponized)
            {
                enemyA.CanDealDamage = false;
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
        private void HandleScore()
        {
            if (enemyA is GreenKoopa && ((GreenKoopa)enemyA).IsWeaponized)
            {
                ScoreManager.IncreaseScore(ScoreManager.HandleShellSequence(shellSequenceIndex));
                ScoreManager.location = WorldManager.camera.GetAdjustedPosition(enemyB.VectorCoordinates);
            }
            if (enemyB is GreenKoopa && ((GreenKoopa)enemyB).IsWeaponized)
            {
                ScoreManager.IncreaseScore(ScoreManager.HandleShellSequence(shellSequenceIndex));
                ScoreManager.location = WorldManager.camera.GetAdjustedPosition(enemyB.VectorCoordinates);
            }
        }
    }
}
