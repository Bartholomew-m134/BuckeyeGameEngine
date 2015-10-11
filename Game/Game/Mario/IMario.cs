using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.States;

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


        void Flower();


        void Mushroom();

        void Star();

        IMarioState GetSetMarioState
        {
            get;
            set;
        }

        void Damage();


        void Die();

        bool IsBig();

        bool IsStar();

        void ToIdle();

    }
}
