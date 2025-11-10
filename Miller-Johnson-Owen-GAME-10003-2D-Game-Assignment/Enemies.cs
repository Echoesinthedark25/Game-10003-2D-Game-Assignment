using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Enemies
    {
        Vector2 position;

        public void Setup()
        {
            float radius = Window.Size.X / 2.0f;
            float angle = Random.Float(0.0f, 2 * MathF.PI);

            position.X = radius * MathF.Cos(angle);
            position.Y = radius * MathF.Sin(angle);
        }

        public void Update()
        {
            Draw.LineSize = 2;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Gray;
            Draw.Circle(position, 7.0f);
            
        }
    }


}
