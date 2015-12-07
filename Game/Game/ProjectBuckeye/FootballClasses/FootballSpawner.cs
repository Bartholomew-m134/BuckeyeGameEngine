using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.ProjectBuckeye.FootballClasses;
using Game.Interfaces;
using Game.ProjectBuckeye.EnemyClasses;
using Game.ProjectBuckeye.EnemyClasses.WolverineChuckStates;

namespace Game.ProjectBuckeye.FootballClasses
{
    public class FootballSpawner
    {
        private Game1 game;
        private int count;
        private const int MAXCOUNT = 2;

        public FootballSpawner(Game1 game)
        {
            this.game = game;
        }

        public void ReleaseFootball(Vector2 location, bool lookingRight, bool isHostile, IGameObject thrower, string type)
        {
            if (count < MAXCOUNT && !(thrower is WolverineChuck))
            {
                Football football = new Football(this, game, lookingRight, isHostile, type);
                football.VectorCoordinates = new Vector2(location.X, location.Y + 10);
                WorldManager.CreateNewObject(football);
                count++;
            }
            else if (isHostile && thrower is WolverineChuck)
            {
                Football football = new Football(this, game, lookingRight, isHostile, type);
                if (((WolverineChuck)thrower).State is WolverineChuckIdleRightState || ((WolverineChuck)thrower).State is WolverineChuckIdleLeftState)
                    football.VectorCoordinates = new Vector2(location.X, location.Y);
                else
                    football.VectorCoordinates = new Vector2(location.X, location.Y + 10);
                WorldManager.CreateNewObject(football);
            }
        }

        public void ReturnFootball()
        {
            if (count > 0)
                count--;
        }
    }
}
