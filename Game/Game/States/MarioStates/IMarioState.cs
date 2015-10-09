using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States
{
    public interface IMarioState
    {
         void Update();

         void Left();


         void Right();


         void Up();


         void Down();


         void Land();


         void Jump();


         void Flower();


         void Mushroom();

         void Star();


         void Damage();


         void Die();

         bool IsBig();
    }
}
