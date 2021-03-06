﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Game.Enemies;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Enemies.KoopaClasses.KoopaStates;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Game.Mario.MarioStates;
using Game.Utilities;
using Game.Enemies.GoombaClasses.GoombaStates;
using Game.SoundEffects;
using Game.Utilities.Constants;
using Game.ProjectPacMario.PlayerClasses;
using Game.ProjectPacMario.EnemyClasses;
using Game.ProjectPacMario.EnemyClasses.EnemyStates;

namespace Game.Collisions.EnemyCollisionHandling
{
    public class MarioEnemyCollisionHandler
    {
        private IMario mario;
        private IEnemy enemy;
        private ICollisionSide side;
        private CollisionData collision;
        public MarioEnemyCollisionHandler(CollisionData collision)
        {
            this.collision = collision;

            side = collision.CollisionSide;
            if (collision.GameObjectA is IMario)
            {
                mario = (IMario)collision.GameObjectA;
                enemy = (IEnemy)collision.GameObjectB;
            }
            else
            {
                mario = (IMario)collision.GameObjectB;
                enemy = (IEnemy)collision.GameObjectA;
                side = side.FlipSide();
            }
        }

        public void HandleCollision()
        {
            HandleScore();
            if (enemy is Boo)
            {
                HandlePacMarioCollision();
            }
            else if (!MarioDeadState() && !mario.IsStarMario() && enemy is GreenKoopa && ((GreenKoopa)enemy).IsHit)
            {
                WeaponizedKoopa();
            }
            else if (!MarioDeadState() && !mario.IsStarMario() && side is TopSideCollision && !enemy.IsFlipped)
            {
                MarioEnemyTopSide();
            }
            else if (!MarioDeadState() && !mario.IsStarMario() && !mario.IsHurt() && enemy.CanDealDamage && !(enemy is Boo))
            {
                collision.ResolveOverlap(mario, side);
                if (mario.IsBigMario())
                    SoundEffectManager.ShrinkingOrPipeEffect();
                mario.Damage();
            }
            else if (mario.IsStarMario())
            {
                enemy.CanDealDamage = false;
                enemy.Flipped();
            }
        }

        private bool MarioDeadState()
        {
            return (mario.MarioState is DeadMarioState);
        }

        private void WeaponizedKoopa()
        {
            collision.ResolveOverlap(mario, side);
            SoundEffectManager.EnemyFlippedEffect();
            if (((GreenKoopa)enemy).state is GreenKoopaEmergingFromShellState)
                ((GreenKoopa)enemy).state = new GreenKoopaHidingInShellState((GreenKoopa)enemy);
            if (side is LeftSideCollision && enemy.Physics.Velocity.X == 0)
            {
                ((GreenKoopa)enemy).IsWeaponized = true;
                enemy.Physics.Velocity = new Vector2(CollisionHandlerConstants.WEAPONIZEDKOOPATRAVELSPEED, enemy.Physics.Velocity.Y);
            }
            else if (side is RightSideCollision && enemy.Physics.Velocity.X == 0)
            {
                ((GreenKoopa)enemy).IsWeaponized = true;
                enemy.Physics.Velocity = new Vector2(-CollisionHandlerConstants.WEAPONIZEDKOOPATRAVELSPEED, enemy.Physics.Velocity.Y);
            }
            else if (side is TopSideCollision)
            {
                ((GreenKoopa)enemy).IsWeaponized = false;
                enemy.Physics.ResetPhysics();
                mario.Physics.Velocity = new Vector2(mario.Physics.Velocity.X, CollisionHandlerConstants.MARIOBUMPSPEEDY);
                mario.Physics.Acceleration = new Vector2(mario.Physics.Acceleration.X, CollisionHandlerConstants.MARIOBUMPACCELERATIONY);
            }
            else if (enemy.Physics.Velocity.X > 0)
            {
                enemy.Physics.Velocity = new Vector2(-CollisionHandlerConstants.WEAPONIZEDKOOPATRAVELSPEED, enemy.Physics.Velocity.Y);
                if (mario.IsBigMario())
                    SoundEffectManager.ShrinkingOrPipeEffect();
                mario.Damage();
            }
            else if (enemy.Physics.Velocity.X < 0)
            {
                enemy.Physics.Velocity = new Vector2(CollisionHandlerConstants.WEAPONIZEDKOOPATRAVELSPEED, enemy.Physics.Velocity.Y);
                if(mario.IsBigMario())
                    SoundEffectManager.ShrinkingOrPipeEffect();
                mario.Damage();
            }
        }

        private void MarioEnemyTopSide()
        {
            collision.ResolveOverlap(mario, side);
            if (enemy is GreenKoopa)
            {
                SoundEffectManager.EnemyFlippedEffect();
            }
            enemy.CanDealDamage = false;
            enemy.Hit();

            mario.Physics.Velocity = new Vector2(mario.Physics.Velocity.X, CollisionHandlerConstants.MARIOBUMPSPEEDY);
            mario.Physics.Acceleration = new Vector2(mario.Physics.Acceleration.X, CollisionHandlerConstants.MARIOBUMPACCELERATIONY);
        }

        private void HandleScore()
        {
            if (!(enemy is Goomba) && !(side is TopSideCollision))
                ScoreManager.stompStreak = ScoreManagerConstants.RESETTOZERO;
            if (enemy is Goomba && !(mario.MarioState is DeadMarioState) && side is TopSideCollision && !(mario is DamagedMarioTransitionDecorator) && !(mario is GrowingMarioTransitionDecorator) && !(mario is StarMarioDecorator))
            {
                if (!(((Goomba)enemy).state is GoombaFlippedState) && !(((Goomba)enemy).state is GoombaSmashedState))
                {
                    ScoreManager.IncreaseScore(ScoreManager.HandleStompSequence(ScoreManager.stompStreak));
                    ScoreManager.stompStreak += ScoreManagerConstants.INCREMENTBYONE;
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
            if (enemy is GreenKoopa && !(mario.MarioState is DeadMarioState) && side is TopSideCollision && !(mario is DamagedMarioTransitionDecorator) && !(mario is GrowingMarioTransitionDecorator) && !(mario is StarMarioDecorator))
            {
                if(!(((GreenKoopa)enemy).state is GreenKoopaEmergingFromShellState) && !(((GreenKoopa)enemy).state is GreenKoopaHidingInShellState)){
                    ScoreManager.IncreaseScore(ScoreManagerConstants.ONEHUNDREDPOINTS);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
            if (mario is StarMarioDecorator && enemy is Goomba){
                if (((Goomba)enemy).state is GoombaWalkingLeftState || ((Goomba)enemy).state is GoombaWalkingRightState)
                {
                    ScoreManager.IncreaseScore(ScoreManagerConstants.ONEHUNDREDPOINTS);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
            if (mario is StarMarioDecorator && enemy is GreenKoopa)
            {
                if (((GreenKoopa)enemy).state is GreenKoopaWalkingLeftState || ((GreenKoopa)enemy).state is GreenKoopaWalkingRightState)
                {
                    ScoreManager.IncreaseScore(ScoreManagerConstants.TWOHUNDREDPOINTS);
                    ScoreManager.location = enemy.VectorCoordinates;
                }
            }
        }
        public void HandlePacMarioCollision()
        {
            if (mario is PacMario){
                mario.Damage();
            }
            else if (!(((Boo)enemy).state is DeadBooState)){
                ((Boo)enemy).Hit();
                ScoreManager.IncreaseScore(ScoreManagerConstants.ONETHOUSANDPOINTS);
                SoundEffectManager.EatGhostEffect();
            }
        }
    }
}
