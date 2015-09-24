using Game.Blocks;
using Game.Enemies.GoombaClasses;
using Game.Enemies.GreenKoopaClasses;
using Game.Items;
using Game.Mario;
using Game.Pipes;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands
{
    public class ResetToDefaultCommand : ICommand
    {
        private Game1 game;

        public ResetToDefaultCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.coin = new Coin(game);
            game.flower = new Flower(game);
            game.greenMushroom = new GreenMushroom(game);
            game.redMushroom = new RedMushroom(game);
            game.star = new Star(game);

            game.mario = new MarioInstance(game);

            game.brickBlock = new Block(1, game);
            game.hiddenBlock = new Block(2, game);
            game.questionBlock = new Block(3, game);
            game.solidBlock = TileSpriteFactory.CreateSolidBlockSprite(game);
            game.breakingBlock = TileSpriteFactory.CreateBreakingBlockSprite(game);

            game.goomba = new Goomba(game);
            game.greenKoopa = new GreenKoopa(game);

            game.pipe = new Pipe(game);
        }
    }
}
