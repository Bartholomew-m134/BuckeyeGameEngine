using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Enemies.KoopaClasses;
using Microsoft.Xna.Framework;
using Game.SoundEffects;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class EnemyEndblockCollisionHandler
    {
        private IGameState gameState;

        public EnemyEndblockCollisionHandler(IGameState gameState)
        {
            this.gameState = gameState;
        }

        public void HandleCollision()
        {
            gameState.FlagPoleTransition();
        }
    }
}
