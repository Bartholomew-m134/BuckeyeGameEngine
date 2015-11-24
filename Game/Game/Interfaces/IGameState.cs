using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IGameState
    {
        void LoadContent();

        void UnloadContent();

        void Update();

        void Draw(SpriteBatch spriteBatch);

        void StartButton();

        void PipeTransition(IPipe warpPipe);

        void FlagPoleTransition();

        void PlayerDied();

        void MarioPowerUp();

        bool IsUnderground { get; set; }

        void StateBackgroundTheme();
    }
}
