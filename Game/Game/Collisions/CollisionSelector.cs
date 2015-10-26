using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Blocks;
using Game.Items;
using Game.Pipes;
using Game.Blocks.BlockStates;
using Game.Collisions.EnemyCollisionHandling;
using Game.Collisions.BlockCollisionHandling;
using Game.Collisions.ItemCollisionHandling;
using Game.Collisions.PipeCollisionHandling;
using Game.Interfaces;
using Game.Collisions.FlagPoleCollisionHandling;

namespace Game.Collisions
{
    public static class CollisionSelector
    {
        public static void HandleCollision(CollisionData collision){

            if ((collision.GameObjectA is IMario && collision.GameObjectB is IEnemy) || (collision.GameObjectA is IEnemy && collision.GameObjectB is IMario))
            {
                MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IMario && collision.GameObjectB is IBlock) || (collision.GameObjectA is IBlock && collision.GameObjectB is IMario))
            {
                MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
      
            }
            else if ((collision.GameObjectA is IMario && collision.GameObjectB is IItem) || (collision.GameObjectA is IItem && collision.GameObjectB is IMario))
            {
                MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IMario && collision.GameObjectB is IPipe) || (collision.GameObjectA is IPipe && collision.GameObjectB is IMario))
            {
                MarioPipeCollisionHandler collisionHandler = new MarioPipeCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if (collision.GameObjectA is IEnemy && collision.GameObjectB is IEnemy)
            {

            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is IBlock) || (collision.GameObjectA is IBlock && collision.GameObjectB is IEnemy))
            {
                EnemyBlockCollisionHandler collisionHandler = new EnemyBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is IPipe) || (collision.GameObjectA is IPipe && collision.GameObjectB is IEnemy))
            {

            }
            else if ((collision.GameObjectA is IItem && collision.GameObjectB is IBlock) || (collision.GameObjectA is IBlock && collision.GameObjectB is IItem))
            {
                ItemBlockCollisionHandler collisionHandler = new ItemBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IItem && collision.GameObjectB is IPipe) || (collision.GameObjectA is IPipe && collision.GameObjectB is IItem))
            {
                ItemPipeCollisionHandler collisionHandler = new ItemPipeCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IMario && collision.GameObjectB is IFlagPole) || (collision.GameObjectA is IFlagPole && collision.GameObjectB is IMario))
            {
                MarioFlagPoleCollisionHandler collisionHandler = new MarioFlagPoleCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
        }
    }
}
