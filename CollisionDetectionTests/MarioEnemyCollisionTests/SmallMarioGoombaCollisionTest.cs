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
    public class SmallMarioGoombaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioGoombaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(-1, 0);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(11, 0);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioGoombaRightSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.VectorCoordinates = new Vector2(14, 0);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(16, 0);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioGoombaBottomSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.VectorCoordinates = new Vector2(0, 14);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(0, 16);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioGoombaTopSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(0, 14);
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
        public void StarSmallMarioGoombaLeftCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 0);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(11, 0);
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

        [TestMethod]
        public void StarSmallMarioGoombaRightCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(14, 0);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(0, 0);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.Flipped();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaFlippedState;
            bool expectedState = expectedGoomba.state is GoombaFlippedState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(16, 0);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarSmallMarioGoombaBottomCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 14);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(0, 0);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.Flipped();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaFlippedState;
            bool expectedState = expectedGoomba.state is GoombaFlippedState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(0, 16);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarSmallMarioGoombaTopCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 0);

            Goomba testGoomba = new Goomba(game);
            testGoomba.VectorCoordinates = new Vector2(0, 14);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.Flipped();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaFlippedState;
            bool expectedState = expectedGoomba.state is GoombaFlippedState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(0, -1);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }
    }
}
