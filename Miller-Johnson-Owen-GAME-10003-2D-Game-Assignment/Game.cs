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

        Enemies[] enemies = new Enemies[35];
        Player player;

        float timer = 0;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Dodge!!!");
            Window.SetSize(600, 600);

            player = new Player();
            player.Setup();

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
            // Stop timer if hp is 0
            if (player.hp > 0)
                timer += Time.DeltaTime;

            Window.ClearBackground(Color.White);

            player.Update(enemies);

            //Update enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Update();
            }
            Console.WriteLine(timer);

            //Draw Timer
            Text.Draw($"Timer: {(int)timer}", 80, Window.Height - 80);
        }

     
    }

}
