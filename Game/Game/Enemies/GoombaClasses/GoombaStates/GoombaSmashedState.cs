using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaSmashedState : IGoombaState
    {
        private Goomba goomba;

        public GoombaSmashedState(Goomba goomba)
        {
            this.goomba = goomba;
            float prevHeight = goomba.Sprite.SpriteDimensions.Y;
            this.goomba.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaSmashedSprite();
            goomba.VectorCoordinates += new Microsoft.Xna.Framework.Vector2(0,prevHeight - goomba.Sprite.SpriteDimensions.Y);
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
