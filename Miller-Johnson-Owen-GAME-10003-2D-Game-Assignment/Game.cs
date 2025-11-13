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

        bool mouseIsInBounds = true;
        int circleX, circleY;

        Enemies[] enemies = new Enemies[20];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Dodge!!!");
            Window.SetSize(800, 600);

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

            DrawPlayer();
            
        }

        //Create player object
        public void DrawPlayer()
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Green;
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);

            if (mouseIsInBounds)
            {
                
            }
        }
    }

}
