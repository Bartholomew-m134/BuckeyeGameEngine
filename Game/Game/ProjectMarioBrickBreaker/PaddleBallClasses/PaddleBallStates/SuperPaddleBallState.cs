using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.PaddleBallClasses.PaddleBallStates
{
    public class SuperPaddleBallState : IPaddleBallState
    {
        private IPaddleBall paddleBall;
        public SuperPaddleBallState(IPaddleBall paddleBall)
        {
            this.paddleBall = paddleBall;
            paddleBall.Sprite = SpriteFactories.MarioBrickBreakerSpriteFactory.CreateSuperPaddleBallSprite();
        }

        public void Update()
        {
            paddleBall.Sprite.Update();
        }

        public void ToSuperPaddleBall()
        {

        }

        public bool IsSuperPaddleBall()
        {
            return true;
        }
    }
}
