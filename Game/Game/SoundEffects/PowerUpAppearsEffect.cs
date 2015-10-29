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

namespace Game.SoundEffects
{
    public class PowerUpAppearsEffect : ISoundEffect
    {
        private Stream backgroundSoundFile = TitleContainer.OpenStream(@"Content\SoundEffects\smb_powerup_appears.wav");
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public PowerUpAppearsEffect()
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