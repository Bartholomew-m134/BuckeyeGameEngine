using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Enemies.GoombaClasses;
using Game.Utilities;
using Game.Enemies.GoombaClasses.GoombaStates;
using Game.Utilities.Constants;
using Game.ProjectPacMario.EnemyClasses;

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
            if(!(enemyA is Boo)){
            collision.ResolveOverlap(collision.GameObjectA, side);
                enemyA.ShiftDirection();
                enemyB.ShiftDirection();
            }
            }
        private void HandleNormalTopOrBottomEnemyCollision()
        {
            if (!(enemyA is Boo))
            {
                if (side is TopSideCollision)
                    collision.ResolveOverlap(enemyA, side);
                else
                    collision.ResolveOverlap(enemyB, side.FlipSide());
            }
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
            if (enemyB is Goomba && enemyA is GreenKoopa){
                if (((GreenKoopa)enemyA).IsWeaponized && (((Goomba)enemyB).state is GoombaWalkingLeftState || ((Goomba)enemyB).state is GoombaWalkingRightState))
                {
                    ScoreManager.location = enemyB.VectorCoordinates;
                    ScoreManager.IncreaseScore(ScoreManager.HandleShellSequence(((GreenKoopa)enemyA).weaponizedShellKillStreak));
                    ((GreenKoopa)enemyA).weaponizedShellKillStreak += ScoreManagerConstants.INCREMENTBYONE;
                    ScoreManager.shellStreak = (((GreenKoopa)enemyA).weaponizedShellKillStreak); 
               }
               if (((GreenKoopa)enemyA).weaponizedShellKillStreak > ScoreManagerConstants.SHELLSEQUENCEMAXINDEX)
                   (((GreenKoopa)enemyA).weaponizedShellKillStreak) = ScoreManagerConstants.RESETTOZERO;
            }
            if (enemyA is Goomba && enemyB is GreenKoopa)
            {
                if (((GreenKoopa)enemyB).IsWeaponized && (((Goomba)enemyA).state is GoombaWalkingLeftState || ((Goomba)enemyA).state is GoombaWalkingRightState))
                {
                    ScoreManager.location = enemyB.VectorCoordinates;
                    ScoreManager.IncreaseScore(ScoreManager.HandleShellSequence(((GreenKoopa)enemyB).weaponizedShellKillStreak));  
                    ((GreenKoopa)enemyB).weaponizedShellKillStreak += ScoreManagerConstants.INCREMENTBYONE;
                    ScoreManager.shellStreak = (((GreenKoopa)enemyB).weaponizedShellKillStreak);
                }
                if ((((GreenKoopa)enemyB).weaponizedShellKillStreak) > ScoreManagerConstants.SHELLSEQUENCEMAXINDEX)
                    (((GreenKoopa)enemyB).weaponizedShellKillStreak) = ScoreManagerConstants.RESETTOZERO;
            }
            
        }
    }
}
