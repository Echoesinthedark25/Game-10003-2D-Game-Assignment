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


        Vector2 position;
        Vector2 size;
        Vector2 velocity;
        

        public void Setup()
        {
            float radius = Window.Size.X / 2.0f - 50.0f;
            float angle = Random.Float(0.0f, 2 * MathF.PI);

            position.X = radius * MathF.Cos(angle);
            position.Y = radius * MathF.Sin(angle);

            //Get velocity for enemies
            
            velocity = Vector2.Normalize(Window.Size / 2.0f - position) * 50.0f;

            
        }

        public void Update()
        {
            position += velocity * Time.DeltaTime;
            
            
            //Set collision for enemies
            leftEdge = position.X;
            rightEdge = position.X + size.X;
            bottomEdge = position.Y;
            topEdge = position.Y + size.Y;
            
            
            Draw.LineSize = 2;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Red;
            Draw.Circle(position, 7.0f);
            
        }
    }


}
