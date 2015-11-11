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
using Game.Utilities.Constants;

namespace Game.SoundEffects
{
    public class SuperMarioJumpEffect : ISoundEffect
    {
        private Stream backgroundSoundFile = TitleContainer.OpenStream(SoundConstants.SUPERMARIOJUMPEFFECT);
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public SuperMarioJumpEffect()
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
