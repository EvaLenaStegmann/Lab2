using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Volume { get; }

        private Vector3 Size { get; }
        private bool IsCube { get; }

        public Cuboid (Vector3 center, Vector3 size)
        {
            Size = size;
            Area = MathF.Round((Size.X * Size.Y + Size.Y * Size.Z + Size.Z * Size.X) * 2.0f, 2);
            Volume = MathF.Round(Size.X * Size.Y * Size.Z, 2);
            Center = center;
            IsCube = Size.X == Size.Y && Size.X == Size.Z;
        }

        public Cuboid (Vector3 center, float width) : this(center, new Vector3(width))
        {
        }

        public override string ToString()
        {
            return $"{(IsCube ? "cube" : "cuboid")} @({Center.X:0.0}, {Center.Y:0.0}, {Center.Z:0.0}): w = {Size.X:0.0}, h = {Size.Y:0.0}, l = {Size.Z:0.0}";
        }
    }
}
