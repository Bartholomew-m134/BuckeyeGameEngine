using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.EnemyClasses.EnemyStates
{
    public class UpPatrolingBooState : IBooState
    {
        private Boo boo;
        public UpPatrolingBooState(Boo boo)
        {
            this.boo = boo;
            this.boo.Sprite = Game.SpriteFactories.PacMarioSpriteFactory.CreateUpBooSprite();
            boo.Physics.Velocity = new Vector2(0, EnemyStatesConstants.WALKINGLEFTVELOCITY);
        }
        public void Die()
        {
            boo.state = new DeadBooState(boo);
        }

        public void Left()
        {
            boo.state = new LeftPatrolingBooState(boo);
        }
        public void Right()
        {
            boo.state = new RightPatrolingBooState(boo);
        }
        public void Down()
        {
            boo.state = new DownPatrolingBooState(boo);
        }
        public void Up()
        {
            
        }
        public void Update()
        {
            boo.Sprite.Update();
        }

    }
}
