using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Interfaces
{
    public interface IEnemy : IGameObject
    {
        void Hit();

        void ShiftDirection();

        void Flipped();

        bool IsFlipped
        {
            get;
            set;
        }

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
    }
}
