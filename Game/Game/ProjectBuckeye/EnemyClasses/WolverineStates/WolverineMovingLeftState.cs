using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineStates
{
    public class WolverineMovingLeftState : IWolverineState
    {
        IWolverine enemy;
        public WolverineMovingLeftState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineLeftMovingSprite();
            enemy.Physics.Velocity = new Vector2(-5, 0);
        }
        public void Damage()
        {
            enemy.State = new WolverineLeftDownState(enemy);
        }

        public void DirectionChange()
        {
            enemy.State = new WolverineMovingRightState(enemy);
        }

        public void Update()
        {
            enemy.Sprite.Update();
        }
    }
}
