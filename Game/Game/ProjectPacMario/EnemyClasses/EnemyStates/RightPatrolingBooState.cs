using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.EnemyClasses.EnemyStates
{
    public class RightPatrolingBooState : IBooState
    {
        private Boo boo;
        public RightPatrolingBooState(Boo boo)
        {
            this.boo = boo;
            this.boo.Sprite = Game.SpriteFactories.PacMarioSpriteFactory.CreateRightBooSprite();
            boo.Physics.Velocity = new Vector2(EnemyStatesConstants.WALKINGRIGHTVELOCITY, 0);
        }
        public void Die()
        {
            boo.state = new DeadBooState(boo);
        }
        public void ChangeDirection()
        {
        }
        public void Left()
        {
            boo.state = new LeftPatrolingBooState(boo);
        }
        public void Right()
        {
            
        }
        public void Down()
        {
            boo.state = new UpPatrolingBooState(boo);
        }
        public void Up()
        {
            boo.state = new UpPatrolingBooState(boo);
        }
        public void Update()
        {
            boo.Sprite.Update();
        }
    }
}
