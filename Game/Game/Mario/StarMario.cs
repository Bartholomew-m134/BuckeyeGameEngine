using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario
{
    class StarMario : IMario
    {
        MarioInstance mario;
        int timer = 1000;
        public StarMario(MarioInstance mario)
        {

            this.mario = mario;
        }

        void Damage()
        {
            // StarMario does not take damage
        }

        void Update()
        {
            timer--;
            if (timer == 0)
            {
                RemoveStar();
            }

            mario.Update();
        }

        void RemoveStar()
        {
            WorldManager.SetMario(mario);
        }

        void IMario.Update()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }

        public void Up()
        {
            throw new NotImplementedException();
        }

        public void Down()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void Flower()
        {
            throw new NotImplementedException();
        }

        public void Mushroom()
        {
            throw new NotImplementedException();
        }

        void IMario.Damage()
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

        void IGameObject.Update()
        {
            throw new NotImplementedException();
        }
    }
}
