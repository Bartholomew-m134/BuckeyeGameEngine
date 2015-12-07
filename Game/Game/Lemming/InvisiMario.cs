using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Mario.MarioStates;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Lemming
{
    public class InvisiMario : IMario
    {
        private IMarioState state;
        private IMarioSprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private IPhysics physics;
        private FireBallSpawner factory;
        private bool isPressingDown;
        private bool isDead;
        private float lemmingLocation;

        public InvisiMario(Game1 game)
        {
            state = new InvisibleState(this);
            myGame = game;
            physics = new MarioGamePhysics();
            physics.Velocity = Vector2.Zero;
            physics.Acceleration = Vector2.Zero;
            factory = new FireBallSpawner(game);
            isPressingDown = false;
            isDead = false;
        }
        public void Update()
        {
            lemmingLocation = WorldManager.ReturnLemming().VectorCoordinates.X;
            location = new Vector2(lemmingLocation,0);
            state.Update();    
        }
        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }
        public void Left()
        {
            
        }
        public void Right()
        {
            
        }
        public void Up()
        {

        }
        public void Down()
        {

        }
        public void Jump()
        {

        }
        public void StopJumping() {
  
        }
        public void Run()
        {

        }
        public void StopRunning()
        {

        }
        public void Flower()
        {

        }

        public void ThrowFireball()
        {
            
        }
        public void Mushroom()
        {
            
        }
        public void Star()
        {   
            
        }
        public void PoleSlide()
        {
            
        }
        public void Damage()
        {
            
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

        public IPhysics Physics
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


        public bool IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }
    }
}
