using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        private IMarioState state;
        private IMarioSprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private ObjectPhysics physics;
        private FireBallSpawner factory;
        private bool isPressingDown;
        private bool isDead;

        public MarioInstance(Game1 game)
        {
            state = new SmallRightIdleState(this);
            myGame = game;
            physics = new ObjectPhysics();
            factory = new FireBallSpawner(game);
            isPressingDown = false;
            isDead = false;
        }
        public void Update()
        {
            location = physics.Update(location);
            state.Update();    
        }
        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }
        public void Left()
        {
            state.Left();
        }
        public void Right()
        {
            state.Right();
        }
        public void Up()
        {
            state.Up();
            this.isPressingDown = false;
        }
        public void Down()
        {
            state.Down();
            this.isPressingDown = true;
        }
        public void Jump()
        {
            if (Physics.Velocity.Y < IMarioObjectConstants.JUMPPREVENTIONCAP)
             state.Jump();
        }
        public void StopJumping() {
            state.StopJumping();
        }
        public void Run()
        {
            state.Run();
        }
        public void StopRunning()
        {
            state.StopRunning();
        }
        public void Flower()
        {
            if (!this.IsFireMario())
            {
                new FireMarioTransitionDecorator(this);
            }
        }

        public void ThrowFireball()
        {
            if (this.IsFireMario())
            {
                if (state.IsRight())
                {
                    factory.ReleaseRightFireBall(new Vector2(location.X + sprite.SpriteDimensions.X, location.Y));
                    new ThrowFireRightDecorator(this, myGame);
                }
                else
                {
                    factory.ReleaseLeftFireBall(location);
                    new ThrowFireLeftDecorator(this, myGame);
                }
            }
        }
        public void Mushroom()
        {
            if(!this.IsBigMario())
            {
                new GrowingMarioTransitionDecorator(this);
            }
        }
        public void Star()
        {   
            new StarMarioDecorator(this, myGame);
        }
        public void PoleSlide()
        {
            Physics.ResetX();
            Physics.ResetY();
            state.PoleSlide();
        }
        public void Damage()
        {
            if (this.IsBigMario())
            {
            state.Damage();
            new DamagedMarioTransitionDecorator(this);
        }
            else
        {
                state.Damage();
            }
        }
        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }
        public ISprite Sprite
        {
            get { return (ISprite)sprite; }
            set { sprite = (IMarioSprite)value; }
        }

        public IMarioState MarioState
        {
            get { return state; }
            set { state = value; }
        }

        public bool IsBigMario()
        {
            return state.IsBigMario();
        }

        public bool IsFireMario()
        {
            return state.IsFireMario();
        }

        public bool IsStarMario()
        {
            return false;
        }

        public bool IsJumping()
        {
            return state.IsJumping();
        }

        public void ToIdle()
        {
            state.ToIdle();
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

        public FireBallSpawner FireBallFactory
        {
            get { return factory; }
        }

        public bool IsHurt()
        {
            return false;
        }


        public bool IsPressingDown()
        {
            return isPressingDown;
        }


        public bool Dead
        {
            get { return isDead; }
            set { isDead = value; }
        }
    }
}
