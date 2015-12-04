using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineChuckStates
{
    public class WolverineChuckIdleRightState : IWolverineState
    {
        IWolverine enemy;
        public WolverineChuckIdleRightState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineChuckIdleRightSprite();
            enemy.Physics.ResetPhysics();
        }
        public void Damage()
        {
        }

        public void DirectionChange()
        {
            enemy.State = new WolverineChuckIdleLeftState(enemy);
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
            enemy.State = new WolverineChuckCharginRightState(enemy);
        }
    }
}
