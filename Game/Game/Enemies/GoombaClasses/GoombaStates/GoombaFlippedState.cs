using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SoundEffects;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaFlippedState : IGoombaState
    {
        private Goomba goomba; 
        public GoombaFlippedState(Goomba goomba)
        {
            this.goomba = goomba;
            SoundEffectManager.EnemyFlippedEffect();
            goomba.Physics.Velocity = new Vector2(0, -5);
            goomba.Physics.Acceleration = new Vector2(0, 1);
            this.goomba.IsFlipped = true;
            this.goomba.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaFlippedSprite();
        }
        public void SmashGoomba()
        {
        }
        public void DirectionChangeGoomba()
        {
        }
        public void FlipGoomba()
        {
        }
    }
}
