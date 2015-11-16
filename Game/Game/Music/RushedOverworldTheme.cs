﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Game.Interfaces;
using Game.Utilities.Constants;

namespace Game.Music
{
    class RushedOverworldTheme : IMusic
    {
        private Stream backgroundSoundFile= TitleContainer.OpenStream(SoundConstants.RUSHOVERWORLDTHEME);
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public RushedOverworldTheme()
        {
            backgroundSoundEffect = SoundEffect.FromStream(backgroundSoundFile);
            instance = backgroundSoundEffect.CreateInstance();
            instance.IsLooped = true;
        }

        public void StopTheme(){
            instance.Stop();
        }

        public void PlayTheme()
        {
            instance.Play();
        }

        public bool IsPlaying()
        {
            bool isPlaying = false;
            if (instance.State == SoundState.Playing)
                isPlaying = true;
            return isPlaying;
        }
    }
}
