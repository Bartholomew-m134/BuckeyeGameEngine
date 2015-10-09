using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class Collision
    {
        public IGameObject gameObjectA;
        public IGameObject gameObjectB;
        public ICollisionSide collisionSide;

        public Collision(IGameObject objectA, IGameObject objectB, ICollisionSide side) {
            gameObjectA = objectA;
            gameObjectB = objectB;
            collisionSide = side;
        }

        public void ResolveOverlap(IGameObject overlappingObject) {
            Rectangle hitBox;
            int xCoordinate = (int)overlappingObject.VectorCoordinates.X;
            int yCoordinate = (int)overlappingObject.VectorCoordinates.Y;


            hitBox = new Rectangle((int)overlappingObject.VectorCoordinates.X, (int)overlappingObject.VectorCoordinates.Y, (int)overlappingObject.GetSprite.SpriteDimensions.X, (int)overlappingObject.GetSprite.SpriteDimensions.Y);
            
            
            if (collisionSide is LeftSideCollision) {
                xCoordinate -= hitBox.Width;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
            else if (collisionSide is RightSideCollision) {
                xCoordinate += hitBox.Width;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
            else if (collisionSide is TopSideCollision)
            {
                yCoordinate -= hitBox.Height;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
            else if (collisionSide is BottomSideCollision)
            {
                yCoordinate += hitBox.Height;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
        }
    }
}
