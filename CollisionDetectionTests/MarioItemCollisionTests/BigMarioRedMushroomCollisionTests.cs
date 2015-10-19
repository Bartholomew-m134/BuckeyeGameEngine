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
    public class BigMarioRedMushroomCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void BigMarioRedMushroomLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();
            testMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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
        public void BigMarioRedMushroomRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();
            testMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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
        public void BigMarioRedMushroomTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();
            testMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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
        public void BigMarioRedMushroomBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();
            testMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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