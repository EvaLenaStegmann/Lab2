using System;
using System.Collections;
using System.Numerics;

namespace ShapeLibrary
{
    public class Triangle : Shape2D, IEnumerable 
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }

        private Vector2[] Vector2Array { get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            Vector2Array = new Vector2[3];
            Vector2Array[0] = p1;
            Vector2Array[1] = p2;
            Vector2Array[2] = p3;

            Area = MathF.Round(MathF.Abs(Vector2Array[0].X * (Vector2Array[1].Y - Vector2Array[2].Y) +
                            Vector2Array[1].X * (Vector2Array[2].Y - Vector2Array[0].Y) +
                            Vector2Array[2].X * (Vector2Array[0].Y - Vector2Array[1].Y)
                            ) / 2.0f, 2);

            Circumference = MathF.Round(Vector2.Distance(p1, p2) + Vector2.Distance(p2, p3) + Vector2.Distance(p3, p1), 2);
            Center = new Vector3(MathF.Round((Vector2Array[0].X + Vector2Array[1].X + Vector2Array[2].X) / 3.0f, 1),
                                 MathF.Round((Vector2Array[0].Y + Vector2Array[1].Y + Vector2Array[2].Y) / 3.0f, 1),
                                 0);
        }

        public override string ToString()
        {
            return $"triangle @({Center.X:0.0}, {Center.Y:0.0}): p1({Vector2Array[0].X:0.0}, {Vector2Array[0].Y:0.0}), p2({Vector2Array[1].X:0.0}, {Vector2Array[1].Y:0.0}), p3({Vector2Array[2].X:0.0}, {Vector2Array[2].Y:0.0})";
        }

        public IEnumerator GetEnumerator()
        {
            return new Vector2ArrayEnum(Vector2Array);
        }
    }
}
