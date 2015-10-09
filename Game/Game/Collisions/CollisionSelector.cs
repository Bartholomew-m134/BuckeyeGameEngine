using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Blocks;
using Game.Items;
using Game.Pipes;
using Game.States.BlockStates;
using Game.Collisions.EnemyCollisionHandling;
using Game.Collisions.BlockCollisionHandling;
using Game.Collisions.ItemCollisionHandling;

namespace Game.Collisions
{
    public static class CollisionSelector
    {
        public static void HandleCollision(Collision collision){

            if ((collision.gameObjectA is IMario && collision.gameObjectB is IEnemy) || (collision.gameObjectA is IEnemy && collision.gameObjectB is IMario))
            {
                MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.gameObjectA is IMario && collision.gameObjectB is IBlock) || (collision.gameObjectA is IBlock && collision.gameObjectB is IMario))
            {
                MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
      
            }
            else if ((collision.gameObjectA is IMario && collision.gameObjectB is IItem) || (collision.gameObjectA is IItem && collision.gameObjectB is IMario))
            {
                MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.gameObjectA is IMario && collision.gameObjectB is IPipe) || (collision.gameObjectA is IPipe && collision.gameObjectB is IMario))
            {

            }
            else if (collision.gameObjectA is IEnemy && collision.gameObjectB is IEnemy)
            {

            }
            else if ((collision.gameObjectA is IEnemy && collision.gameObjectB is IBlock) || (collision.gameObjectA is IBlock && collision.gameObjectB is IEnemy))
            {

            }
            else if ((collision.gameObjectA is IEnemy && collision.gameObjectB is IPipe) || (collision.gameObjectA is IPipe && collision.gameObjectB is IEnemy))
            {

            }
            else if ((collision.gameObjectA is IItem && collision.gameObjectB is IBlock) || (collision.gameObjectA is IBlock && collision.gameObjectB is IItem))
            {

            }
            else if ((collision.gameObjectA is IItem && collision.gameObjectB is IPipe) || (collision.gameObjectA is IPipe && collision.gameObjectB is IItem))
            {

            }
        }
    }
}
