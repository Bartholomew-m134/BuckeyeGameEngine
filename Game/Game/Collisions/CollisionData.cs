using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class CollisionData
    {
        public IGameObject gameObjectA;
        public IGameObject gameObjectB;
        public ICollisionSide collisionSide;

        public CollisionData(IGameObject objectA, IGameObject objectB, ICollisionSide side) {
            gameObjectA = objectA;
            gameObjectB = objectB;
            collisionSide = side;
        }

        public void ResolveOverlap(IGameObject overlappingObject, ICollisionSide side) {
            int xCoordinate = (int)overlappingObject.VectorCoordinates.X;
            int yCoordinate = (int)overlappingObject.VectorCoordinates.Y;

            Rectangle hitBoxA = new Rectangle((int)gameObjectA.VectorCoordinates.X, (int)gameObjectA.VectorCoordinates.Y, (int)gameObjectA.GetSetSprite.SpriteDimensions.X, (int)gameObjectA.GetSetSprite.SpriteDimensions.Y);
            Rectangle hitBoxB = new Rectangle((int)gameObjectB.VectorCoordinates.X, (int)gameObjectB.VectorCoordinates.Y, (int)gameObjectB.GetSetSprite.SpriteDimensions.X, (int)gameObjectB.GetSetSprite.SpriteDimensions.Y);

            Rectangle collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);   
            
            if (side is LeftSideCollision) {
                xCoordinate -= collisionRectangle.Width;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate );
                overlappingObject.VectorCoordinates = newLocation;
            }
            else if (side is RightSideCollision) {
                xCoordinate += collisionRectangle.Width;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
            else if (side is TopSideCollision)
            {
                yCoordinate -= collisionRectangle.Height;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
            else if (side is BottomSideCollision)
            {
                yCoordinate += collisionRectangle.Height;
                Vector2 newLocation = new Vector2(xCoordinate, yCoordinate);
                overlappingObject.VectorCoordinates = newLocation;
            }
        }
    }
}
