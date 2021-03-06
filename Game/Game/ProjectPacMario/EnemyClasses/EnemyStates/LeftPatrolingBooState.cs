﻿using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectPacMario.EnemyClasses.EnemyStates
{
    public class LeftPatrolingBooState : IBooState
    {
        private Boo boo;
        public LeftPatrolingBooState(Boo boo)
        {
            this.boo = boo;
            this.boo.Sprite = Game.SpriteFactories.PacMarioSpriteFactory.CreateLeftBooSprite();
            boo.Physics.Velocity = new Vector2(EnemyStatesConstants.WALKINGLEFTVELOCITY, 0);
        }
        public void Die()
        {
            boo.state = new DeadBooState(boo);
        }

        public void Left()
        {
            
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
            boo.state = new UpPatrolingBooState(boo);
        }
        public void Update()
        {
            boo.Sprite.Update();
        }
    }
}
