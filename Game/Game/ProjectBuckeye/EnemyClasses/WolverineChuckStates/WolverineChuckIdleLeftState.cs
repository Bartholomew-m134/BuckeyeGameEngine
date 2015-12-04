using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineChuckStates
{
    public class WolverineChuckIdleLeftState : IWolverineState
    {
        IWolverine enemy;
        public WolverineChuckIdleLeftState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineChuckIdleLeftSprite();
            enemy.Physics.ResetPhysics();
        }
        public void Damage()
        {
        }

        public void DirectionChange()
        {
            enemy.State = new WolverineChuckIdleRightState(enemy);
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
            enemy.State = new WolverineChuckCharginLeftState(enemy);
        }
    }
}
