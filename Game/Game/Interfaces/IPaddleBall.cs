using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IPaddleBall : IGameObject
    {
        IPaddleBallState PaddleBallState
        {
            get;
            set;
        }

        void ToSuperPaddleBall();

        bool IsSuperPaddleBall();
    }
}
