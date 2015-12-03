using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.PaddleBallClasses.PaddleBallStates
{
    public class NormalPaddleBallState : IPaddleBallState
    {
        private IPaddleBall paddleBall;
        public NormalPaddleBallState(IPaddleBall paddleBall) {
            this.paddleBall = paddleBall;
            paddleBall.Sprite = SpriteFactories.MarioBrickBreakerSpriteFactory.CreateNormalPaddleBallSprite();
        }

        public void Update()
        {
            paddleBall.Sprite.Update();
        }

        public void ToSuperPaddleBall()
        {
            paddleBall.PaddleBallState = new SuperPaddleBallState(paddleBall);
        }

        public bool IsSuperPaddleBall()
        {
            return false;
        }
    }
}
