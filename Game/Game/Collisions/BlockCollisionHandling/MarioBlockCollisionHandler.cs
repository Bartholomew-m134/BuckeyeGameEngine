﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Blocks;
using Game.Blocks.BlockStates;
using System.Diagnostics;
using Game.Interfaces;
using Game.Mario.MarioStates;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.ProjectPacMario.PlayerClasses;
using Game.ProjectPacMario.Blocks.BlockStates;

namespace Game.Collisions.BlockCollisionHandling
{
    public class MarioBlockCollisionHandler
    {

        private IMario collidingMario;
        private Block collidingBlock;
        private ICollisionSide collisionSide;
        private CollisionData collision;

        public MarioBlockCollisionHandler(CollisionData collision)
        {
            this.collision = collision;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IMario)
            {
                collidingMario = (IMario)collision.GameObjectA;
                collidingBlock = (Block)collision.GameObjectB;
            }
            else
            {
                collidingMario = (IMario)collision.GameObjectB;
                collidingBlock = (Block)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            HandleScore();
            if (!(collidingMario.MarioState is DeadMarioState))
            {

                if (collisionSide is RightSideCollision)
                {
                    HandleRightSide();
                }
                else if (collisionSide is LeftSideCollision)
                {
                    HandleLeftSide();
                }
                else if (collisionSide is TopSideCollision)
                {
                    HandleTopSide();
                }
                else
                {
                    HandleBottomSide();
                }
            }
            
        }
        private void HandleTopSide()
        {
            if (!(collidingBlock.State is HiddenBlockState) && !(collidingBlock.State is BrickDebrisState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
                if (collidingMario.IsJumping())
                {
                    collidingMario.MarioState.ToIdle();
                }
                collidingMario.Physics.ResetY();
                
            }

        }
        private void HandleBottomSide()
        {
            if (collidingBlock.State is HiddenBlockState && collidingMario.Physics.Velocity.Y <= 0)
            {
                collidingBlock.GetUsed();
                collidingBlock.Bump();
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
            else if (collidingBlock.State is BrickBlockState && collidingMario.IsBigMario())
            {
                collidingBlock.Bump();
                collidingBlock.Disappear();
            }
            else if (collidingBlock.State is BrickBlockState && !(collidingMario.IsBigMario()))
            {
                collidingBlock.Bump();
                collision.ResolveOverlap(collidingMario, collisionSide);
            } 
            else if (collidingBlock.State is QuestionBlockState)
            {
                collidingBlock.GetUsed();
                collidingBlock.Bump();
                collision.ResolveOverlap(collidingMario, collisionSide);
            } 
            else if (!(collidingBlock.State is BrickDebrisState) && !(collidingBlock.State is HiddenBlockState)){
                collision.ResolveOverlap(collidingMario, collisionSide);
            }
           
            if(!(collidingBlock.State is NullBlockState || collidingBlock.State is BrickDebrisState || collidingBlock.State is HiddenBlockState))
                collidingMario.Physics.ResetY();
        }
        private void HandleRightSide()
        {
            if (!(collidingBlock.State is HiddenBlockState) && !(collidingBlock.State is BrickDebrisState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
               
            }
            if (collidingBlock.State is TeleportBlockState && collidingMario is PacMario)
            {
                ((PacMario)collidingMario).TeleportRight();
            }
            else if (collidingBlock.State is TeleportBlockState && collidingMario is StarMarioDecorator)
            {
                ((StarMarioDecorator)collidingMario).TeleportRight();
            }

        }
        private void HandleLeftSide()
        {
            if (!(collidingBlock.State is HiddenBlockState) && !(collidingBlock.State is BrickDebrisState))
            {
                collision.ResolveOverlap(collidingMario, collisionSide);
                
            }
            if (collidingBlock.State is TeleportBlockState && collidingMario is PacMario)
            {
                ((PacMario)collidingMario).TeleportLeft();
            }
            else if (collidingBlock.State is TeleportBlockState && collidingMario is StarMarioDecorator)
            {
                ((StarMarioDecorator)collidingMario).TeleportLeft();
            }
        }

        private void HandleScore()
        {
            ScoreManager.stompStreak = ScoreManagerConstants.RESETTOZERO;
            if (collidingBlock.State is BrickBlockState && collidingMario.IsBigMario() && collisionSide is BottomSideCollision)
            {
                ScoreManager.IncreaseScore(ScoreManagerConstants.FIFTYPOINTS);
                ScoreManager.location = collidingBlock.VectorCoordinates;
            }
        }
    }
}
