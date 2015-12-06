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
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        private IGameState gameState;

        public EnemyEndblockCollisionHandler(CollisionData collision, IGameState gamestate)
        {
            this.collision = collision;
            this.gameState = gamestate;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IEnemy)
            {
                enemy = (IEnemy)collision.GameObjectA;
            }
            else
            {
                enemy = (IEnemy)collision.GameObjectB;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            gameState.FlagPoleTransition();
        }
    }
}
