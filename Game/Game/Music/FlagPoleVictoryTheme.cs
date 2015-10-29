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

namespace Game.Music
{
    public class FlagPoleVictoryTheme : IMusic
    {
        private Stream backgroundSoundFile = TitleContainer.OpenStream(@"Content\SoundTracks\06-level-complete.wav");
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public FlagPoleVictoryTheme()
        {
            backgroundSoundEffect = SoundEffect.FromStream(backgroundSoundFile);
            instance = backgroundSoundEffect.CreateInstance();
            instance.IsLooped = false;
        }

        public void StopTheme(){
            instance.Stop();
        }

        public void PlayTheme()
        {
            instance.Play();
        }
    }
}