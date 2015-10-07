using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario
{
    public interface IMario : IGameObject
    {
        void Update();

        void Draw();

        void Left();


        void Right();


        void Up();


        void Down();


        void Land();


        void Jump();


        void Flower();


        void Mushroom();


        void Damage();


        void Die();
    }
}
