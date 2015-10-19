using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game;
using Game.Blocks;
using Game.Collisions;
using Game.Collisions.BlockCollisionHandling;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;

namespace CollisionDetectionTests
{
    [TestClass]
    public class BigMarioQuestionBlockCollisionTests
    {
        Game1 game = new Game1();

        [TestMethod]
        public void BigMarioQuestionBlockLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(-12, 0);

            Block testBlock = new Block(Block.Type.QuestionBlock, game);
            Block expectedBlock = new Block(Block.Type.QuestionBlock, game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioQuestionBlockRightSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            Block testBlock = new Block(Block.Type.QuestionBlock, game);
            Block expectedBlock = new Block(Block.Type.QuestionBlock, game);
            expectedMario.VectorCoordinates = new Vector2(12, 0);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioQuestionBlockTopSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            Block testBlock = new Block(Block.Type.QuestionBlock, game);
            Block expectedBlock = new Block(Block.Type.QuestionBlock, game);
            expectedMario.VectorCoordinates = new Vector2(0, -15);

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void BigMarioQuestionBlockBottomSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(0, 15);

            Block testBlock = new Block(Block.Type.QuestionBlock, game);
            Block expectedBlock = new Block(Block.Type.QuestionBlock, game);
            expectedBlock.GetUsed();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testBlock, side);
            MarioBlockCollisionHandler collisionHandler = new MarioBlockCollisionHandler(collision);

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
