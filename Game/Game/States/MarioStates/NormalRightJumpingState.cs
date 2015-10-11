using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class NormalRightJumpingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalRightJumpingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightJumpingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalLeftJumpingState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X += 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y -= 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightJumpingState(mario, game);
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
            mario.GetSetMarioState = new SmallRightJumpingState(mario, game);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }

        public void ToIdle()
        {

        }
    }
}
