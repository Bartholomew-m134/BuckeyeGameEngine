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
    public class SmallMarioRedMushroomCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioRedMushroomLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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
        public void SmallMarioRedMushroomRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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
        public void SmallMarioRedMushroomTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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
        public void SmallMarioRedMushroomBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Mushroom();

            RedMushroom testRedMushroom = new RedMushroom(game);
            RedMushroom expectedRedMushroom = new RedMushroom(game);
            expectedRedMushroom.Disappear();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testRedMushroom, side);
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