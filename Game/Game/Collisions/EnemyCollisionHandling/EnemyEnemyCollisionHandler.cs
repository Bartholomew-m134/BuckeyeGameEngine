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

        public void HandleCollision()
        {
            HandleScore();
            if (enemyA.IsHit == false && enemyB.IsHit == false && LeftOrRightCollision())
            {
                HandleNormalLeftOrRightEnemyCollision();
            }
            else if (enemyA.IsHit == false && enemyB.IsHit == false && TopOrBottomCollision())
            {
                HandleNormalTopOrBottomEnemyCollision();
            }
            else if (enemyA is GreenKoopa && ((GreenKoopa)enemyA).IsWeaponized || enemyB is GreenKoopa && ((GreenKoopa)enemyB).IsWeaponized)
            {
                HandleWeaponizedKoopaCollisions();
            }
            else if (enemyA.IsHit)
            {
                collision.ResolveOverlap(collision.GameObjectA, side);
                enemyB.ShiftDirection();
            }
            else if (enemyB.IsHit)
            {
                collision.ResolveOverlap(collision.GameObjectA, side);
                enemyA.ShiftDirection();
            }
        }

        private bool LeftOrRightCollision()
        {
            return (side is LeftSideCollision || side is RightSideCollision);
        }

        private bool TopOrBottomCollision()
        {
            return (side is TopSideCollision || side is BottomSideCollision);
        }

        private void HandleNormalLeftOrRightEnemyCollision(){
            collision.ResolveOverlap(collision.GameObjectA, side);
                enemyA.ShiftDirection();
                enemyB.ShiftDirection();
            }
        private void HandleNormalTopOrBottomEnemyCollision()
        {
            if (side is TopSideCollision)
                collision.ResolveOverlap(enemyA, side);
            else
                collision.ResolveOverlap(enemyB, side.FlipSide());
        }

        private void HandleWeaponizedKoopaCollisions()
        {
            if (enemyA is GreenKoopa && ((GreenKoopa)enemyA).IsWeaponized)
            {
                enemyB.CanDealDamage = false;
                enemyB.Flipped();
            }
            else if (enemyB is GreenKoopa && ((GreenKoopa)enemyB).IsWeaponized)
            {
                enemyA.CanDealDamage = false;
                enemyA.Flipped();
            }
        }
        private void HandleScore()
        {
            if (enemyA is GreenKoopa && ((GreenKoopa)enemyA).IsWeaponized)
            {
                ScoreManager.IncreaseScore(ScoreManager.HandleShellSequence(shellSequenceIndex));
                ScoreManager.location = enemyB.VectorCoordinates;
            }
            if (enemyB is GreenKoopa && ((GreenKoopa)enemyB).IsWeaponized)
            {
                ScoreManager.IncreaseScore(ScoreManager.HandleShellSequence(shellSequenceIndex));
                ScoreManager.location = enemyB.VectorCoordinates;
            }
        }
    }
}
