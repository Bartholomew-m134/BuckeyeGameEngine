using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineChuckStates
{
    class WolverineChuckCharginRightState : IWolverineState
    {
        IWolverine enemy;
        public WolverineChuckCharginRightState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineChuckCharginRightSprite();
            enemy.Physics.VelocityMaximum = new Vector2(10, enemy.Physics.VelocityMaximum.Y);
            enemy.Physics.VelocityMinimum = new Vector2(-10, enemy.Physics.VelocityMinimum.Y);
            enemy.Physics.Velocity = new Vector2(10, 0);
        }
        public void Damage()
        {
        }

        public void DirectionChange()
        {
            enemy.State = new WolverineChuckCharginLeftState(enemy);
        }

        public void Update()
        {
            enemy.Sprite.Update();
        }


        public void Idle()
        {
        }
    }
}
