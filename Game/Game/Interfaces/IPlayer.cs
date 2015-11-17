using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IPlayer : IGameObject
    {
        void Left();

        void Right();

        void Up();

        void Down();

        void Jump();

        void StopJumping();

        void Run();

        void StopRunning();

        bool Dead
        {
            get;
            set;
        }

        bool IsPressingDown();

        bool IsJumping();

        void ToIdle();
    }
}
