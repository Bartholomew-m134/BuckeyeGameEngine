using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Projectiles;
using Game.Interfaces;
using Game.Utilities;
using Game.Enemies.GoombaClasses;
using Game.Enemies.GoombaClasses.GoombaStates;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyFireballCollisionHandler
    {
        private IEnemy enemy;
        private IProjectile fireball;
        private CollisionData collision;

        public EnemyFireballCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
                fireball = (IProjectile)collision.GameObjectB;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                fireball = (IProjectile)collision.GameObjectA;
            }
        }

        public void HandleCollision()
        {
            HandleScore();
            enemy.CanDealDamage = false;
            enemy.Flipped();
            fireball.Explode();
        }

        public void HandleScore(){
            if (enemy is Goomba)
            {
                if (((Goomba)enemy).state is GoombaWalkingLeftState || ((Goomba)enemy).state is GoombaWalkingRightState)
                {
                    ScoreManager.location = enemy.VectorCoordinates;
                    ScoreManager.IncreaseScore(100);
                }
            }
            else if (!(((GreenKoopa)enemy).state is GreenKoopaFlippedInShellState))
            {
                    ScoreManager.location = enemy.VectorCoordinates;
                    ScoreManager.IncreaseScore(100);
            }
        }
    }
}
