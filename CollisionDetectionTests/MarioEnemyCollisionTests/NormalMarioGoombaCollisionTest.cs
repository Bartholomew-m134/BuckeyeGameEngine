using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.GoombaClasses.GoombaStates;
using Game.Collisions;
using Game.Collisions.EnemyCollisionHandling;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;

namespace CollisionDetectionTests.MarioEnemyCollisionTests
{
    [TestClass]
    public class NormalMarioGoombaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void NormalMarioGoombaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(-1, 0);

            testMario.GetSetMarioState = new NormalRightIdleState(testMario);
            expectedMario.GetSetMarioState = new NormalRightIdleState(expectedMario);

            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(14, 0);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void NormalMarioGoombaRightSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.VectorCoordinates = new Vector2(14, 0);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(16, 0);

            testMario.GetSetMarioState = new NormalRightIdleState(testMario);
            expectedMario.GetSetMarioState = new NormalRightIdleState(expectedMario);

            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void NormalMarioGoombaBottomSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.VectorCoordinates = new Vector2(0, 14);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(0, 16);

            testMario.GetSetMarioState = new NormalRightIdleState(testMario);
            expectedMario.GetSetMarioState = new NormalRightIdleState(expectedMario);

            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void NormalMarioGoombaTopSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);

            testMario.GetSetMarioState = new NormalRightIdleState(testMario);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(0, 30);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.IsHit();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaSmashedState;
            bool expectedState = expectedGoomba.state is GoombaSmashedState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(0, -1);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarNormalMarioGoombaCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Mushroom();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 0);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(14, 0);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.Flipped();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaFlippedState;
            bool expectedState = expectedGoomba.state is GoombaFlippedState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(-1, 0);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }
    }
}
