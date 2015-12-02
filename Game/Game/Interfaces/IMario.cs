using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Interfaces
{
    public interface IMario : IPlayer
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

        void ThrowFireball();

        void Mushroom();

        void Star();

        void PoleSlide();

        IMarioState MarioState
        {
            get;
            set;
        }

        void Damage();

        bool IsBigMario();

        bool IsFireMario();

        bool IsStarMario();

        bool IsHurt();

        bool IsPressingDown();

        bool IsJumping();

        void ToIdle();

    }
}
