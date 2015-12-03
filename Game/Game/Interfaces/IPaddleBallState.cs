using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IPaddleBallState
    {
        void Update();

        void ToSuperPaddleBall();

        bool IsSuperPaddleBall();
    }
}
