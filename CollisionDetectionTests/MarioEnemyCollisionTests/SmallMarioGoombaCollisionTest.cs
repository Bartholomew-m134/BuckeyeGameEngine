using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game.States;
using Game;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Collisions;
using Game.Collisions.EnemyCollisionHandling;
using Microsoft.Xna.Framework;

namespace CollisionDetectionTests.MarioEnemyCollisionTests
{
    class SmallMarioGoombaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioGoombaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is DeadMarioState;
            bool expectedState = expectedMario.state is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        public void SmallMarioGoombaRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is DeadMarioState;
            bool expectedState = expectedMario.state is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        public void SmallMarioGoombaBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is DeadMarioState;
            bool expectedState = expectedMario.state is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }
    }
}
