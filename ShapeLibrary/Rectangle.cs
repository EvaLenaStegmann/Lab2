using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }

        private Vector2 Size { get; } 
        private bool IsSquare { get;  }

        public Rectangle (Vector2 center, Vector2 size)
        {
            Size = size;
            Area = MathF.Round(Size.X * Size.Y, 2);
            Circumference = MathF.Round((Size.X + Size.Y) * 2.0f, 2);
            Center = new Vector3(center.X, center.Y, 0.0f);
            IsSquare = Size.X == Size.Y;
        }

        public Rectangle (Vector2 center, float width) : this(center, new Vector2(width))
        {
        }

        public override string ToString()
        {
            return $"{(IsSquare ? "square" : "rectangle")} @({Center.X:0.0}, {Center.Y:0.0}): w = {Size.X:0.0}, h = {Size.Y:0.0}"; 
        }
    }
}