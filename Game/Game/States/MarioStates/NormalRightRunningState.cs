﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class NormalRightRunningState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private IMario imario;

        public NormalRightRunningState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            this.imario = (IMario)mario;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalRightIdleState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.X += 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new NormalRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new NormalRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireRightRunningState(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            imario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightRunningState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
