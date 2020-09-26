using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Circle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }
        private float Radius { get; } = 0;

        public Circle (Vector2 center, float radius) 
        {
            Radius = radius;
            Area = MathF.Round(Radius * Radius * MathF.PI, 2);
            Circumference = MathF.Round(Radius * 2.0f * MathF.PI, 2);
            Center = new Vector3(center.X, center.Y, 0.0f);
        }

        public override string ToString()
        {
            return $"circle @({Center.X:0.0}, {Center.Y:0.0}): r = {Radius:0.0}";
        }
    }
}
