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
    public class BigMarioGreenMushroomCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void BigMarioGreenMushroomLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            GreenMushroom testGreenMushroom = new GreenMushroom(game);
            GreenMushroom expectedGreenMushroom = new GreenMushroom(game);
            expectedGreenMushroom.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenMushroom, side);
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
        public void BigMarioGreenMushroomRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            GreenMushroom testGreenMushroom = new GreenMushroom(game);
            GreenMushroom expectedGreenMushroom = new GreenMushroom(game);
            expectedGreenMushroom.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenMushroom, side);
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
        public void BigMarioGreenMushroomTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            GreenMushroom testGreenMushroom = new GreenMushroom(game);
            GreenMushroom expectedGreenMushroom = new GreenMushroom(game);
            expectedGreenMushroom.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenMushroom, side);
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
        public void BigMarioGreenMushroomBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            GreenMushroom testGreenMushroom = new GreenMushroom(game);
            GreenMushroom expectedGreenMushroom = new GreenMushroom(game);
            expectedGreenMushroom.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenMushroom, side);
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