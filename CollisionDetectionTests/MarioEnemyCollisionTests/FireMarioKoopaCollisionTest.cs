﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Mario;
using Game;
using Game.Enemies;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Collisions;
using Game.Collisions.EnemyCollisionHandling;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;

namespace CollisionDetectionTests.MarioEnemyCollisionTests
{
    [TestClass]
    public class FireMarioKoopaCollisionTest
    {
        Game1 game = new Game1();

        [TestMethod]
        public void FireMarioKoopaLeftSideCollisionTest()
        {
            MarioInstance testMario = new MarioInstance(game);
            MarioInstance expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(-1, 0);

            testMario.MarioState = new FireRightIdleState(testMario);
            expectedMario.MarioState = new FireRightIdleState(expectedMario);

            expectedMario.Damage();

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            testGreenKoopa.VectorCoordinates = new Vector2(14, 0);

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.MarioState is FireRightIdleState;
            bool expectedState = expectedMario.MarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void FireMarioKoopaRightSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.VectorCoordinates = new Vector2(14, 0);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(16, 0);

            testMario.MarioState = new FireRightIdleState(testMario);
            expectedMario.MarioState = new FireRightIdleState(expectedMario);

            expectedMario.Damage();

            GreenKoopa testGreenKoopa = new GreenKoopa(game);

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.MarioState is FireRightIdleState;
            bool expectedState = expectedMario.MarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void FireMarioKoopaBottomSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.VectorCoordinates = new Vector2(0, 19);
            IMario expectedMario = new MarioInstance(game);
            expectedMario.VectorCoordinates = new Vector2(0, 21);
            expectedMario.Damage();

            GreenKoopa testGreenKoopa = new GreenKoopa(game);

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testMario.MarioState is FireRightIdleState;
            bool expectedState = expectedMario.MarioState is FireRightIdleState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = expectedMario.VectorCoordinates;

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void FireMarioKoopaTopSideCollisionTest()
        {
            IMario testMario = new MarioInstance(game);
            testMario.MarioState = new FireRightIdleState(testMario);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            testGreenKoopa.VectorCoordinates = new Vector2(0, 30);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);

            expectedGreenKoopa.Hit();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaHidingInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaHidingInShellState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(0, -1);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarFireMarioKoopaLeftCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Flower();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 0);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            testGreenKoopa.VectorCoordinates = new Vector2(14, 0);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);
            expectedGreenKoopa.Flipped();

            ICollisionSide side = new LeftSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaFlippedInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaFlippedInShellState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(-1, 0);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarFireMarioKoopaRightCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Flower();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(14, 0);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            testGreenKoopa.VectorCoordinates = new Vector2(0, 0);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);
            expectedGreenKoopa.Flipped();

            ICollisionSide side = new RightSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaFlippedInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaFlippedInShellState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(16, 0);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarFireMarioKoopaBottomCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Flower();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 19);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            testGreenKoopa.VectorCoordinates = new Vector2(0, 0);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);
            expectedGreenKoopa.Flipped();

            ICollisionSide side = new BottomSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaFlippedInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaFlippedInShellState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(0, 21);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }

        [TestMethod]
        public void StarFireMarioKoopaTopCollisionTest()
        {
            WorldManager.LoadListFromFile("World1-1", game);
            IMario testMario = WorldManager.GetMario();
            testMario.Flower();
            testMario.Star();
            testMario = WorldManager.GetMario();
            testMario.VectorCoordinates = new Vector2(0, 0);

            GreenKoopa testGreenKoopa = new GreenKoopa(game);
            testGreenKoopa.VectorCoordinates = new Vector2(0, 30);
            GreenKoopa expectedGreenKoopa = new GreenKoopa(game);
            expectedGreenKoopa.Flipped();

            ICollisionSide side = new TopSideCollision();
            CollisionData collision = new CollisionData(testMario, testGreenKoopa, side);
            MarioEnemyCollisionHandler collisionHandler = new MarioEnemyCollisionHandler(collision);

            collisionHandler.HandleCollision();

            bool testState = testGreenKoopa.state is GreenKoopaFlippedInShellState;
            bool expectedState = expectedGreenKoopa.state is GreenKoopaFlippedInShellState;
            Vector2 testLocation = testMario.VectorCoordinates;
            Vector2 expectedLocation = new Vector2(0, -1);

            Assert.AreEqual(testState, expectedState);
            Assert.AreEqual(testLocation, expectedLocation);
        }
    }
}
