using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Pipes
{
    public class Pipe : IPipe
    {
        private Game1 myGame;
        private ISprite pipeSprite;
        private Vector2 location;

        public Pipe(Game1 game)
        {
            myGame = game;
            pipeSprite = TileSpriteFactory.CreatePipeSprite(game);
            location = new Vector2(600,200);

        }

        public void Update()
        {
            pipeSprite.Update();
        }

        public void Draw() {
            pipeSprite.Draw(myGame.spriteBatch, location);
        }
    }


}
