using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class CollisionData
    {
        private IGameObject gameObjectA;
        private IGameObject gameObjectB;
        private ICollisionSide collisionSide;
        private Rectangle collisionRectangle;

        public CollisionData(IGameObject objectA, IGameObject objectB, ICollisionSide side) {
            collisionRectangle = new Rectangle();
            gameObjectA = objectA;
            gameObjectB = objectB;
            collisionSide = side;
        }

        public void ResolveOverlap(IGameObject overlappingObject, ICollisionSide side) {
            int xCoordinate = (int)overlappingObject.VectorCoordinates.X;
            int yCoordinate = (int)overlappingObject.VectorCoordinates.Y;

            Rectangle hitBoxA = new Rectangle((int)gameObjectA.VectorCoordinates.X, (int)gameObjectA.VectorCoordinates.Y, (int)gameObjectA.Sprite.SpriteDimensions.X, (int)gameObjectA.Sprite.SpriteDimensions.Y);
            Rectangle hitBoxB = new Rectangle((int)gameObjectB.VectorCoordinates.X, (int)gameObjectB.VectorCoordinates.Y, (int)gameObjectB.Sprite.SpriteDimensions.X, (int)gameObjectB.Sprite.SpriteDimensions.Y);

            collisionRectangle = Rectangle.Intersect(hitBoxA, hitBoxB);   
            
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

        public int OverlapArea() {
            return collisionRectangle.X * collisionRectangle.Y;
        }

        public IGameObject GameObjectA 
        {
            get { return gameObjectA; }
        }

        public IGameObject GameObjectB
        {
            get { return gameObjectB; }
        }

        public ICollisionSide CollisionSide
        {
            get { return collisionSide; }
        }

    }
}
