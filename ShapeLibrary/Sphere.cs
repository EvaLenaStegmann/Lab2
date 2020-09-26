using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Volume { get; }
        private float Radius { get; } = 0.0f;

        public Sphere(Vector3 center, float radius)
        {
            Radius = radius;
            Area = MathF.Round(Radius * Radius * MathF.PI * 4.0f, 2);
            Volume = MathF.Round(MathF.Pow(Radius, 3.0f) * MathF.PI * 4.0f / 3.0f, 2); 
            Center = center;
        }

        public override string ToString()
        {
            return $"sphere @({Center.X:0.0}, {Center.Y:0.0}, {Center.Z:0.0}): r = {Radius:0.0}";
        }
    }
}
