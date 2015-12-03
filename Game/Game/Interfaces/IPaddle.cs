using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IPaddle : IPlayer
    {
        void Left();

        void Right();

        void ReleaseBall();

        void MushroomPowerUp();
    }
}
