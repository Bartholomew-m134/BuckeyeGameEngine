using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.EnemyClasses.EnemyStates
{
    public class DownPatrolingBooState : IBooState
    {
        private Boo boo;
        public DownPatrolingBooState(Boo boo)
        {
            this.boo = boo;
            this.boo.Sprite = Game.SpriteFactories.PacMarioSpriteFactory.CreateDownBooSprite();
            boo.Physics.Velocity = new Vector2(0, EnemyStatesConstants.WALKINGRIGHTVELOCITY);
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
            boo.state = new RightPatrolingBooState(boo);
        }
        public void Down()
        {

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
