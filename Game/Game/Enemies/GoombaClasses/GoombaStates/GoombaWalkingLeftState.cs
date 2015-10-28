using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaWalkingLeftState : IGoombaState
    {
        private Goomba goomba;
        public GoombaWalkingLeftState(Goomba goomba)
        {
            this.goomba = goomba;
            this.goomba.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaWalkingLeftSprite();

            Vector2 velocity = this.goomba.Physics.Velocity;
            velocity.X = -2;
            this.goomba.Physics.Velocity = velocity;
        }
        public void SmashGoomba()
        {
            goomba.state = new GoombaSmashedState(goomba);
        }
        public void DirectionChangeGoomba()
        {
            goomba.state = new GoombaWalkingRightState(goomba);
        }
        public void FlipGoomba()
        {
            ScoreManager.location = this.goomba.VectorCoordinates;
            ScoreManager.IncreaseScore(100);
            goomba.state = new GoombaFlippedState(goomba);
        }
    }
}
