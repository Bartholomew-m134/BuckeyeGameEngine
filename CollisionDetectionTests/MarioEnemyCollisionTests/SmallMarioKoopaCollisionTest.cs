using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game.States;
using Game;
using Game.Enemies;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Collisions;
using Game.Collisions.EnemyCollisionHandling;
using Microsoft.Xna.Framework;

namespace CollisionDetectionTests.MarioEnemyCollisionTests
{
    [TestClass]
    public class SmallMarioKoopaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioKoopaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            GreenKoopa testGreenKoopa = new GreenKoopa(game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void SmallMarioKoopaRightSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            GreenKoopa testGreenKoopa = new GreenKoopa(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void SmallMarioKoopaBottomSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            GreenKoopa testGreenKoopa = new GreenKoopa(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void SmallMarioKoopaTopSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);
            expectedGreenKoopa.IsHit();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaHidingInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaHidingInShellState;

            Assert.AreEqual(testState, expectedState);
        }

        [TestMethod]
        public void StarSmallMarioKoopaCollisionTest()
        {
            IMario mario = new MarioInstance(game);
            IMario testMario = new StarMario(mario, game);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);
            expectedGreenKoopa.Flipped();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaFlippedInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaFlippedInShellState;

            Assert.AreEqual(testState, expectedState);
        }
    }
}
