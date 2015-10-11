using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class FireRightRunningState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public FireRightRunningState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireRightRunningSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new FireRightIdleState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X += 2;
            WorldManager.GetMario().VectorCoordinates = loc;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new FireRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new FireRightJumpingState(mario, game);
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
            mario.GetSetMarioState = new NormalRightRunningState(mario, game);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
