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
    public class SmallMarioBreakingBlockCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioBreakingBlockLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(-12, 0);

            Block testBlock = new Block(Block.Type.BreakingBlock, game);
            Block expectedBlock = new Block(Block.Type.BreakingBlock, game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioBreakingBlockRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(12, 0);

            Block testBlock = new Block(Block.Type.BreakingBlock, game);
            Block expectedBlock = new Block(Block.Type.BreakingBlock, game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioBreakingBlockTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(0, -15);

            Block testBlock = new Block(Block.Type.BreakingBlock, game);
            Block expectedBlock = new Block(Block.Type.BreakingBlock, game);

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void SmallMarioBreakingBlockBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(0, 15);
            Block testBlock = new Block(Block.Type.BreakingBlock, game);
            Block expectedBlock = new Block(Block.Type.BreakingBlock, game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is SmallRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is SmallRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

    }
}
