using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Player
    {
        public float topEdge;
        public float bottomEdge;
        public float leftEdge;
        public float rightEdge;
        
        float circleX, circleY;
        float mouseX, mouseY;
        bool isMouseInBoundsX = false;
        bool isMouseInBoundsY = false;
        int xBound = 200;
        int yBound = 200;

        public int hp = 0;

        public void Setup()
        {
           
            hp = 1;
        }

        //Get collision for player
        public void Update(Enemies[] enemies)
        {
            mouseX = Input.GetMouseX();
            mouseY = Input.GetMouseY();
            isMouseInBoundsX = mouseX > xBound && mouseX < Window.Width - xBound;
            isMouseInBoundsY = mouseY > yBound && mouseY < Window.Height - yBound;

            if (isMouseInBoundsX && isMouseInBoundsY)
            {
                circleX = Input.GetMouseX();
                circleY = Input.GetMouseY();
            }

            Draw.FillColor = Color.Green;

            // Stop drawing player if hp is 0
            if (hp > 0)
            {
                Draw.Circle(circleX, circleY, 10);
            }


            ProcessCollision(enemies);
        }

        void ProcessCollision(Enemies[] enemies)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Enemies enemy = enemies[i];

                // check if player collides with enemy
                bool isPointInCircle = Vector2.Distance(new Vector2(circleX, circleY), enemy.position) <= enemy.size;

                // if collide reduce hp
                if (isPointInCircle)
                {
                    hp--;
                }
                
            }
        }
    }
}
