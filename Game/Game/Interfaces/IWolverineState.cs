using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IWolverineState
    {
        void Update();
        void Damage();
        void DirectionChange();
        void Idle();
        void Move();
    }
}
