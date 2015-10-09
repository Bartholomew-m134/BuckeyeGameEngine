﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallLeftRunningState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private IMario imario;

        public SmallLeftRunningState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            this.imario = (IMario)mario;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.X-=4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Right()
        {
            mario.state = new SmallLeftIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new SmallLeftIdleState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new SmallLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireLeftRunningState(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalLeftRunningState(mario, game);
        }

        public void Star()
        {
            imario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.state = new DeadMarioState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return false;
        }
    }
}
