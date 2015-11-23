using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;

namespace Game.ProjectBuckeye.EnemyClasses.WolverineStates
{
    public class WolverineRightDownState : IWolverineState
    {
        IWolverine enemy;
        public WolverineRightDownState(IWolverine enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = Game.SpriteFactories.WolverineSpriteFactory.CreateWolverineRightDownSprite();
            enemy.Physics.ResetPhysics();
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
