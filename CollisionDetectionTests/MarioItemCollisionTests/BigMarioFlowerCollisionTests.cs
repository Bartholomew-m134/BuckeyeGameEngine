﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game.States;
using Game;
using Game.Items;
using Game.Collisions;
using Game.Collisions.ItemCollisionHandling;
using Microsoft.Xna.Framework;

namespace CollisionDetectionTests
{
    [TestClass]
    public class BigMarioFlowerCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void BigMarioFlowerLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is FireRightIdleState;
            bool expectedState = expectedMario.state is FireRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioFlowerRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is FireRightIdleState;
            bool expectedState = expectedMario.state is FireRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }


        [TestMethod]
        public void BigMarioFlowerTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is FireRightIdleState;
            bool expectedState = expectedMario.state is FireRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioFlowerBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();
            expectedMario.Flower();

            Flower testFlower = new Flower(game);
            Flower expectedFlower = new Flower(game);
            expectedFlower.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testFlower, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is FireRightIdleState;
            bool expectedState = expectedMario.state is FireRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }
    }
}