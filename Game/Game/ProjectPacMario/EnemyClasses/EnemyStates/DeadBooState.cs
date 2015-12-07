using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.EnemyClasses.EnemyStates
{
    public class DeadBooState : IBooState
    {
        private Boo boo;

        public DeadBooState(Boo boo)
        {
            this.boo = boo;
            boo.Sprite = Game.SpriteFactories.PacMarioSpriteFactory.CreateDeadBooSprite();
            boo.Physics.ResetPhysics();
        }
        public void Die()
        {
        }

        public void Left()
        {

        }
        public void Right()
        {

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
