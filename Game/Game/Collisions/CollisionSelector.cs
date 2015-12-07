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
using Game.ProjectBuckeye.Collision;
using Game.Lemming;
using Game.Lemming.Elevators;
using Game.ProjectMarioBrickBreaker.Collision;

namespace Game.Collisions
{
    public static class CollisionSelector
    {
        public static void HandleCollision(CollisionData collision, IGameState gameState){

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
                MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision, gameState);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IMario && collision.GameObjectB is IPipe) || (collision.GameObjectA is IPipe && collision.GameObjectB is IMario))
            {
                MarioPipeCollisionHandler collisionHandler = new MarioPipeCollisionHandler(collision, gameState);
                collisionHandler.HandleCollision();
            }
            else if (collision.GameObjectA is IEnemy && collision.GameObjectB is IEnemy)
            {
                EnemyEnemyCollisionHandler collisionHandler = new EnemyEnemyCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is IBlock) || (collision.GameObjectA is IBlock && collision.GameObjectB is IEnemy))
            {
                EnemyBlockCollisionHandler collisionHandler = new EnemyBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is IPipe) || (collision.GameObjectA is IPipe && collision.GameObjectB is IEnemy))
            {
                EnemyPipeCollisionHandler collisionHandler = new EnemyPipeCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is IProjectile) || (collision.GameObjectA is IProjectile && collision.GameObjectB is IEnemy))
            {
                EnemyFireballCollisionHandler collisionHandler = new EnemyFireballCollisionHandler(collision);
                collisionHandler.HandleCollision();
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
            else if ((collision.GameObjectA is IBlock && collision.GameObjectB is IProjectile) || (collision.GameObjectA is IProjectile && collision.GameObjectB is IBlock))
            {
                BlockFireballCollisionHandler collisionHandler = new BlockFireballCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IPipe && collision.GameObjectB is IProjectile) || (collision.GameObjectA is IProjectile && collision.GameObjectB is IPipe))
            {
                PipeFireballCollisionHandler collisionHandler = new PipeFireballCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IMario && collision.GameObjectB is IFlagPole) || (collision.GameObjectA is IFlagPole && collision.GameObjectB is IMario))
            {
                MarioFlagPoleCollisionHandler collisionHandler = new MarioFlagPoleCollisionHandler(collision, gameState);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IBuckeyePlayer && collision.GameObjectB is IBuckeyeTile) || (collision.GameObjectA is IBuckeyeTile && collision.GameObjectB is IBuckeyePlayer))
            {
                BuckeyeTileCollisionHandler collisionHandler = new BuckeyeTileCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IBuckeyePlayer && collision.GameObjectB is IProjectile) || (collision.GameObjectA is IProjectile && collision.GameObjectB is IBuckeyePlayer))
            {
                BuckeyeProjectileCollisionHandler collisionHandler = new BuckeyeProjectileCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IWolverine && collision.GameObjectB is IBuckeyeTile) || (collision.GameObjectA is IBuckeyeTile && collision.GameObjectB is IWolverine))
            {
                WolverineTileCollisionHandler collisionHandler = new WolverineTileCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IWolverine && collision.GameObjectB is IProjectile) || (collision.GameObjectA is IProjectile && collision.GameObjectB is IWolverine))
            {
                WolverineProjectileCollisionHandler collisionHandler = new WolverineProjectileCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IBuckeyePlayer && collision.GameObjectB is IWolverine) || (collision.GameObjectA is IWolverine && collision.GameObjectB is IBuckeyePlayer))
            {
                BuckeyeWolverineCollisionHandler collisionHandler = new BuckeyeWolverineCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IProjectile && collision.GameObjectB is IProjectile) || (collision.GameObjectA is IProjectile && collision.GameObjectB is IProjectile))
            {
                ProjectileProjectileCollisionHandler collisionHandler = new ProjectileProjectileCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IProjectile && collision.GameObjectB is IBuckeyeTile) || (collision.GameObjectA is IBuckeyeTile && collision.GameObjectB is IProjectile))
            {
                ProjectileTileCollisionHandler collisionHandler = new ProjectileTileCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is Elevator) || (collision.GameObjectA is Elevator && collision.GameObjectB is IEnemy))
            {
                EnemyElevatorCollisionHandler collisionHandler = new EnemyElevatorCollisionHandler(collision, gameState);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IEnemy && collision.GameObjectB is Endblock) || (collision.GameObjectA is Endblock && collision.GameObjectB is IEnemy))
            {
                EnemyEndblockCollisionHandler collisionHandler = new EnemyEndblockCollisionHandler(gameState);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IItem && collision.GameObjectB is IPaddleBall) || (collision.GameObjectA is IPaddleBall && collision.GameObjectB is IItem))
            {
                PaddleBallItemCollisionHandler collisionHandler = new PaddleBallItemCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IBlock && collision.GameObjectB is IPaddle) || (collision.GameObjectA is IPaddle && collision.GameObjectB is IBlock))
            {
                PaddleBlockCollisionHandler collisionHandler = new PaddleBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IPaddleBall && collision.GameObjectB is IPaddle) || (collision.GameObjectA is IPaddle && collision.GameObjectB is IPaddleBall))
            {
                PaddlePaddleBallCollisionHandler collisionHandler = new PaddlePaddleBallCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
            else if ((collision.GameObjectA is IPaddleBall && collision.GameObjectB is IBlock) || (collision.GameObjectA is IBlock && collision.GameObjectB is IPaddleBall))
            {
                PaddleBallBlockCollisionHandler collisionHandler = new PaddleBallBlockCollisionHandler(collision);
                collisionHandler.HandleCollision();
            }
        }
    }
}
