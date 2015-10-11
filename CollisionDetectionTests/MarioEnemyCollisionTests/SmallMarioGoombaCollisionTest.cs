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
    public class SmallMarioGoombaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void SmallMarioGoombaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        public void SmallMarioGoombaRightSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        public void SmallMarioGoombaBottomSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.Damage();

            Goomba testGoomba = new Goomba(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGoomba, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.GetSetMarioState is DeadMarioState;
            bool expectedState = expectedMario.GetSetMarioState is DeadMarioState;

            Assert.AreEqual(testState, expectedState);
        }

        public void SmallMarioGoombaTopSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);

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
    }
}
