using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class FireLeftCrouchingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public FireLeftCrouchingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftCrouchingSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new FireLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new FireRightRunningState(mario, game);
        }

        public void Up()
        {
            mario.MarioStateProperty = new FireLeftIdleState(mario, game);
        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y += 4;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Land()
        {

        }

        public void Jump()
        {

        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
        }
        
       public void Star()
        {

            mario = new StarMario(mario, game);

        }

        public void Damage()
        {
            mario.MarioStateProperty = new NormalLeftIdleState(mario, game);
        }

        public void Die()
        {
            mario.MarioStateProperty = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
