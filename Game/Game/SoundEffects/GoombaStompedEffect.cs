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

namespace Game.SoundEffects
{
    public class GoombaStompedEffect : ISoundEffect
    {
        private Stream backgroundSoundFile = TitleContainer.OpenStream(SoundConstants.GOOMBASTOMPEDEFFECT);
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public GoombaStompedEffect()
        {
            backgroundSoundEffect = SoundEffect.FromStream(backgroundSoundFile);
            instance = backgroundSoundEffect.CreateInstance();
            instance.IsLooped = false;
        }

        public void Play()
        {
            instance.Play();
        }
    }
}
