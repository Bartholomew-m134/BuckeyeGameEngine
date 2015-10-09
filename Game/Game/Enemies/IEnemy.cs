using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Enemies
{
    public interface IEnemy : IGameObject
    {
        void IsHit();

        void ShiftDirection();

        void Flipped();


        bool CanDealDamage
        {
            get;
            set;
        }
    }
}
