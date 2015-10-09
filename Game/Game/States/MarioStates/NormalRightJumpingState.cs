using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class NormalRightJumpingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;
        private IMario imario;

        public NormalRightJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            this.imario = (IMario)mario;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightJumpingSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalLeftJumpingState(mario, game);
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

        }

        public void Land()
        {
            mario.state = new NormalRightIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y -= 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Flower()
        {
            mario.state = new FireRightJumpingState(mario, game);
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
            mario.state = new SmallRightJumpingState(mario, game);
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
