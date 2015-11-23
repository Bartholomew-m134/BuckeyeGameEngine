using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;


namespace Game.Lemming
{
    public class LemmingInstance : ILemming
    {
        private bool isDead;
        private bool isJumping;
        private bool isPressingDown;
    //    private ILemmingState state;
        private ISprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private ObjectPhysics physics;


            public LemmingInstance(Game1 game)
        {
           // state = new LemmingWalkingRightState(this);
            myGame = game;
            physics = new ObjectPhysics();
            isDead = false;
            isJumping = false;
            isPressingDown = false;
        }
        public void Update(){
            location = physics.Update(location);
            //state.Update(); 
        }

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }
        public void Left(){

        }

        public void Right(){

        }

        public void Up(){

        }

        public void Down(){

        }

        public void Jump(){

        }

        public void StopJumping(){

        }

        public bool IsJumping()
        {
            return isJumping;
        }

        public bool IsPressingDown()
        {
            return isPressingDown;
        }

        public void Run(){

        }

        public void StopRunning(){

        }

        public bool Dead
        {
            get { return isDead; }
            set { isDead = value; }
        }

        public void ToIdle()
        {

        }
        public ObjectPhysics Physics
        {
            get { return physics; }
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
     }
 }

