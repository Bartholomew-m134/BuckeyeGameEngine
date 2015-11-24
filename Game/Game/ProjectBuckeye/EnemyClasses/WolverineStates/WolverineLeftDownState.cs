using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineStates
{
    public class WolverineLeftDownState : IWolverineState
    {
        IWolverine enemy;
        public WolverineLeftDownState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineLeftDownSprite();
            enemy.Physics.ResetPhysics();

            this.enemy.CanDealDamage = false;
            this.enemy.IsHit = false;
        }
        public void Damage()
        {
        }

        public void DirectionChange()
        {
        }

        public void Update()
        {
            enemy.Sprite.Update();
        }
    }
}
