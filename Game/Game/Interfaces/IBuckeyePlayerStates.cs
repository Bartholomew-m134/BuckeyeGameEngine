using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IBuckeyePlayerState : IPlayerState
    {
        void DownPlayer();
        bool IsJumping{
            get;
        }
    }
}
