using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game;
using Game.Items;
using Game.Collisions;
using Game.Collisions.ItemCollisionHandling;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;

namespace CollisionDetectionTests
{
    [TestClass]
    public class BigMarioStarCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void BigMarioStarLeftSideCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Star();

            Star testStar = new Star(game);
            Star expectedStar = new Star(game);
            expectedStar.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testStar, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioStarRightSideCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Star();

            Star testStar = new Star(game);
            Star expectedStar = new Star(game);
            expectedStar.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testStar, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioStarTopSideCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Star();

            Star testStar = new Star(game);
            Star expectedStar = new Star(game);
            expectedStar.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testStar, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioStarBottomSideCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Star();

            Star testStar = new Star(game);
            Star expectedStar = new Star(game);
            expectedStar.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testStar, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }
    }
}