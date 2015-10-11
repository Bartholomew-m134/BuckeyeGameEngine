﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game.States;
using Game;
using Game.Blocks;
using Game.Collisions;
using Game.Collisions.BlockCollisionHandling;
using Microsoft.Xna.Framework;

namespace CollisionDetectionTests
{
    [TestClass]
    public class SmallMarioSolidBlockCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioSolidBlockLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            Block testBlock = new Block(4, game);
            Block expectedBlock = new Block(4, game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is SmallRightIdleState;
            bool expectedState = expectedMario.state is SmallRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioSolidBlockRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            Block testBlock = new Block(4, game);
            Block expectedBlock = new Block(4, game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is SmallRightIdleState;
            bool expectedState = expectedMario.state is SmallRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioSolidBlockTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            Block testBlock = new Block(4, game);
            Block expectedBlock = new Block(4, game);

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is SmallRightIdleState;
            bool expectedState = expectedMario.state is SmallRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioSolidBlockBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            Block testBlock = new Block(4, game);
            Block expectedBlock = new Block(4, game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.state is SmallRightIdleState;
            bool expectedState = expectedMario.state is SmallRightIdleState;
            Vector2 testLocation = testMario.getLocation();
            Vector2 expectedLocation = expectedMario.getLocation();

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

    }
}