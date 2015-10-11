using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class NormalLeftCrouchingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalLeftCrouchingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftCrouchingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.GetSetMarioState = new NormalRightRunningState(mario, game);
        }

        public void Up()
        {
            mario.GetSetMarioState = new NormalLeftIdleState(mario, game);
        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y += 2;
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
            mario.GetSetMarioState = new FireLeftCrouchingState(mario, game);
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
            mario.GetSetMarioState = new SmallLeftIdleState(mario, game);
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
