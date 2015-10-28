using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaWalkingRightState : IGoombaState
    {
        private Goomba goomba;
        public GoombaWalkingRightState(Goomba goomba)
        {
            this.goomba = goomba;
            this.goomba.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaWalkingRightSprite();

            Vector2 velocity = this.goomba.Physics.Velocity;
            velocity.X = 2;
            this.goomba.Physics.Velocity = velocity;
        }
        public void SmashGoomba()
        {
            goomba.state = new GoombaSmashedState(goomba);
        }
        public void DirectionChangeGoomba()
        {
            goomba.state = new GoombaWalkingLeftState(goomba);
        }
        public void FlipGoomba()
        {
            goomba.state = new GoombaFlippedState(goomba);
        }
    }
}
