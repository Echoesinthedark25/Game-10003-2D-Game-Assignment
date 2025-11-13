// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        float circleX, circleY;
        float mouseX, mouseY;
        bool isMouseInBoundsX = false;
        bool isMouseInBoundsY = false;
        int xBound = 200;
        int yBound = 200;

        Enemies[] enemies = new Enemies[100];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Dodge!!!");
            Window.SetSize(600, 600);

            circleX = Window.Width / 2;
            circleY = Window.Height / 2;

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new Enemies();
                enemies[i].Setup();
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            //Create player and boundary for player
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
            Draw.Circle(circleX, circleY, 20);

            //Update enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Update();
            }

        }

     
    }

}
