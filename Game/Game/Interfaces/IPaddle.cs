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

        void RespawnPaddleBall();

        bool IsMagnetized
        {
            get;
            set;
        }

        void MushroomPowerUp();
    }
}
