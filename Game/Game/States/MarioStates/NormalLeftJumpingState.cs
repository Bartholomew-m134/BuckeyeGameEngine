using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class NormalLeftJumpingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalLeftJumpingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftJumpingSprite();
        }

        public void Update()
        {
            mario.GetSetSprite.Update();
        }
        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X -= 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Right()
        {
            mario.GetSetMarioState = new NormalRightJumpingState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.GetSetMarioState = new NormalLeftIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y -= 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftJumpingState(mario, game);
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
            mario.GetSetMarioState = new SmallLeftJumpingState(mario, game);
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
