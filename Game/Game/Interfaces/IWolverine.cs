using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IWolverine : IGameObject
    {
        void Hit();

        void ShiftDirection();

        bool IsHit
        {
            get;
            set;
        }

        bool CanDealDamage
        {
            get;
            set;
        }

        IWolverineState State
        {
            get;
            set;
        }

        void Throw();

        void Idle();
    }
}
