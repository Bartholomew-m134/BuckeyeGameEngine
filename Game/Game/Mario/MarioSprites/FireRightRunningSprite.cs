using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game.Mario.MarioSprites
{
    public class FireRightRunningSprite : ISprite
    {
        private Game1 game;
        private Texture2D spriteSheet;
        public FireRightRunningSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet; 
        }
        void Update()
        {

        }

        void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

        }
    }
}
