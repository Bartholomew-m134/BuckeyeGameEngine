using System;
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
    public class StompEffect :ISoundEffect
    {
        private const String STOMP_SOUND_EFFECT = @"Content\SoundEffects\stomp.wav";
        private Stream backgroundSoundFile = TitleContainer.OpenStream(STOMP_SOUND_EFFECT);
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public StompEffect()
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
