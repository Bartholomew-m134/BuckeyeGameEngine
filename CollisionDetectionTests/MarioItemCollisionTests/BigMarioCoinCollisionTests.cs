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
    public class BigMarioCoinCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void BigMarioCoinLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            Coin testCoin = new Coin(game);
            Coin expectedCoin = new Coin(game);
            expectedCoin.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testCoin, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is NormalRightIdleState;
            bool expectedState = expectedMario.state is NormalRightIdleState;

            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioCoinRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            Coin testCoin = new Coin(game);
            Coin expectedCoin = new Coin(game);
            expectedCoin.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testCoin, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is NormalRightIdleState;
            bool expectedState = expectedMario.state is NormalRightIdleState;

            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioCoinTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            Coin testCoin = new Coin(game);
            Coin expectedCoin = new Coin(game);
            expectedCoin.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testCoin, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is NormalRightIdleState;
            bool expectedState = expectedMario.state is NormalRightIdleState;

            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioCoinBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            testMario.Mushroom();
            expectedMario.Mushroom();

            Coin testCoin = new Coin(game);
            Coin expectedCoin = new Coin(game);
            expectedCoin.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testCoin, side);
            MarioItemCollisionHandler collisionHandler = new MarioItemCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is NormalRightIdleState;
            bool expectedState = expectedMario.state is NormalRightIdleState;

            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

    }
}