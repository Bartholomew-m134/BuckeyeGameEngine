using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario
{
    public interface IMario : IGameObject
    {
        void Left();


        void Right();


        void Up();


        void Down();

        void Jump();

        void StopJumping();

        void Run();

        void StopRunning();

        void Flower();

        void Fire();

        void Mushroom();

        void Star();

        void PoleSlide();

        IMarioState MarioState
        {
            get;
            set;
        }

        void Damage();

        bool isTransitioning();

        bool IsBig();

        bool isFire();

        bool IsStar();

        bool isHurt();

        bool IsJumping();

        void ToIdle();

    }
}
