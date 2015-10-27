using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IMarioState
    {
         void Update();

         void Left();


         void Right();


         void Up();


         void Down();


         void Jump();

         void StopJumping();

         void Run();

         void StopRunning();

         void Flower();

         void Fire();

         void Mushroom();

         void Star();


         void Damage();


         void Die();

         bool IsBig();

         bool IsJumping();

         void ToIdle();

         void PoleSlide();
    }
}
