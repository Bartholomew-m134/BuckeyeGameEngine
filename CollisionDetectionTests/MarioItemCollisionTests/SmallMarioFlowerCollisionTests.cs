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
    public class SmallMarioFlowerCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioFlowerLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is FireRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioFlowerRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is FireRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }


        [TestMethod]
        public void SmallMarioFlowerTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is FireRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioFlowerBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is FireRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }
    }
}