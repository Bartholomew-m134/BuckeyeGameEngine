﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IMusic
    {
        void StopTheme();

        void PlayTheme();

        bool IsPlaying();
    }
}
