﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class SmallLeftRunningState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallLeftRunningState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X-=2;
            WorldManager.GetMario().VectorCoordinates = loc;
        }

        public void Right()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new SmallLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftRunningState(mario, game);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalLeftRunningState(mario, game);
        }

        public void Star()
        {
            mario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return false;
        }

        public void ToIdle()
        {
            mario.Right();
        }
    }
}
