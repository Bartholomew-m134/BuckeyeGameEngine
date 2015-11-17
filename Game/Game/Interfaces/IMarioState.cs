using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IMarioState : IPlayerState
    {
         void Flower();

         void Mushroom();

         void Star();

         void Damage();

         bool IsBigMario();

         bool IsFireMario();

         bool IsRight();

         void PoleSlide();

         void FlipAroundPole();
    }
}
