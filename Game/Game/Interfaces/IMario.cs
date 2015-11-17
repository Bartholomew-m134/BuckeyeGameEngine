using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario
{
    public interface IMario : IPlayer
    {
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

    }
}
