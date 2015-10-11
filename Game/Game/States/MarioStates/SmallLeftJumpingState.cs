using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class SmallLeftJumpingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallLeftJumpingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftJumpingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X -= 4;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Right()
        {
            mario.GetSetMarioState = new SmallRightJumpingState(mario, game);
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
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y -= 4;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftJumpingState(mario, game);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalLeftJumpingState(mario, game);
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

        }
    }
}
