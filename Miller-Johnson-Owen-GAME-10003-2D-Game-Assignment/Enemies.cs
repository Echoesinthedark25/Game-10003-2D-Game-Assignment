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
        public float topEdge;
        public float bottomEdge;
        public float leftEdge;
        public float rightEdge;


        public Vector2 position;
        public float size = 7f;
        Vector2 velocity;
        

        public void Setup()
        {
            float radius = Window.Size.X / 2.0f - 50.0f;
            float angle = Random.Float(0.0f, 2 * MathF.PI);

            position.X = radius * MathF.Cos(angle) + Window.Width / 2 + Random.Integer(-60, 90);
            position.Y = radius * MathF.Sin(angle) + Window.Height /2 + Random.Integer(-90, 60);

            //Get velocity for enemies
            
            velocity = Vector2.Normalize(Window.Size / 2.0f - position) * 50.0f * Random.Integer(2, 4) * 0.3f ;

            
        }

        public void Update()
        {
            position += velocity * Time.DeltaTime;
            
            if (position.X < 0  || position.Y < 0 || position.X > Window.Width || position.Y > Window.Height)
            {
                velocity = -velocity;
            }

            //Set collision for enemies
            leftEdge = position.X;
            //rightEdge = position.X + size.X;
            bottomEdge = position.Y;
            //topEdge = position.Y + size.Y;
            
            
            Draw.LineSize = 2;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Red;
            Draw.Circle(position, size);

            
        }
    }


}
