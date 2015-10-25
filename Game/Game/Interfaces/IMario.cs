using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Mario
{
    public interface IMario : IGameObject
    {
        void Left();


        void Right();


        void Up();


        void Down();


        void Land();


        void Jump();

        void StopJumping();

        void Flower();


        void Mushroom();

        void Star();

        IMarioState MarioState
        {
            get;
            set;
        }

        void Damage();


        void Die();

        bool IsBig();

        bool IsStar();

        bool IsJumping();

        void ToIdle();

    }
}
