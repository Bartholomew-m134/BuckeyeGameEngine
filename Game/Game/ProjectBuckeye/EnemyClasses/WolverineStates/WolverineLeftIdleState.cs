using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using Game.ProjectBuckeye.EnemyClasses;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineStates
{
    public class WolverineLeftIdleState : IWolverineState
    {
        IWolverine enemy;
        public WolverineLeftIdleState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineLeftIdleSprite();
        }
        public void Damage()
        {
            enemy.State = new WolverineLeftDownState(enemy);
        }

        public void DirectionChange()
        {
        }

        public void Update()
        {
            enemy.Sprite.Update();
        }


        public void Idle()
        {
        }


        public void Move()
        {
        }
    }
}
