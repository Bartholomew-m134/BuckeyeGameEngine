using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game.States;
using Game;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.GoombaClasses.GoombaStates;
using Game.Collisions;
using Game.Collisions.EnemyCollisionHandling;
using Microsoft.Xna.Framework;

namespace CollisionDetectionTests.MarioEnemyCollisionTests
{
    [TestClass]
    public class FireMarioGoombaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void FireMarioGoombaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);

            testMario.GetSetMarioState = new FireRightIdleState(testMario, game);
            expectedMario.GetSetMarioState = new FireRightIdleState(expectedMario, game);

            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void FireMarioGoombaRightSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            IMario expectedMario = new MarioInstance(game);

            testMario.GetSetMarioState = new FireRightIdleState(testMario, game);
            expectedMario.GetSetMarioState = new FireRightIdleState(expectedMario, game);

            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void FireMarioGoombaBottomSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            IMario expectedMario = new MarioInstance(game);

            testMario.GetSetMarioState = new FireRightIdleState(testMario, game);
            expectedMario.GetSetMarioState = new FireRightIdleState(expectedMario, game);

            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is NormalRightIdleState;
            bool expectedState = expectedMario.GetSetMarioState is NormalRightIdleState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void FireMarioGoombaTopSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);

            testMario.GetSetMarioState = new FireRightIdleState(testMario, game);

            Goomba testGoomba = new Goomba(game);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.IsHit();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaSmashedState;
            bool expectedState = expectedGoomba.state is GoombaSmashedState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void StarFireMarioGoombaCollisionTest()
        {
            IMario mario = new MarioInstance(game);
            mario.GetSetMarioState = new FireRightIdleState(mario, game);
            IMario testMario = new StarMario(mario, game);

            Goomba testGoomba = new Goomba(game);
            Goomba expectedGoomba = new Goomba(game);
            expectedGoomba.Flipped();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGoomba.state is GoombaFlippedState;
            bool expectedState = expectedGoomba.state is GoombaFlippedState;

            Assert.AreEqual(testState, expectedState);
        }
    }
}
