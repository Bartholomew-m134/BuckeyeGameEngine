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

        void PipeTransition(Vector2 warpLocation);

        void FlagPoleTransition();

        void PlayerDied();

        void MarioPowerUp();

        bool IsUnderground { get; set; }
    }
}
