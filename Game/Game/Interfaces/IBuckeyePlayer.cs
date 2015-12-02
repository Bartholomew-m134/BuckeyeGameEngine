using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IBuckeyePlayer : IPlayer
    {
        IBuckeyePlayerState State
        {
            get;
            set;
        }

        void Left();

        void Right();

        void Up();

        void Down();

        void Jump();

        void StopJumping();

        void Run();

        void StopRunning();

        void Damage();

        bool IsFacingRight
        {
            get;
            set;
        }

        bool IsPressingDown();

        bool IsJumping();

        void ToIdle();
    }
}
