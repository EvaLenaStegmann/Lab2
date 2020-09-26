using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Random rnd = new Random();
            Vector3 vector3 = new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
            return GenerateShape(vector3);
        }

        public static Shape GenerateShape(Vector3 vector3)
        {

            Random rnd = new Random();
            int typeOfShape = rnd.Next(0, 7);

            switch (typeOfShape)
            {
                case 0: // circle
                    return new Circle(new Vector2(vector3.X, vector3.Y), (float)Math.Round(rnd.NextDouble() * 10, 1));
                case 1: // rectangle
                    return new Rectangle(new Vector2(vector3.X, vector3.Y), new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1)));
                case 2: // square
                    return new Rectangle(new Vector2(vector3.X, vector3.Y), (float)Math.Round(rnd.NextDouble() * 10, 1));
                case 3:
                    // triangle
                    Vector2 p1 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                    Vector2 p2 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                    return new Triangle(p1,
                                        p2,
                                        new Vector2(MathF.Round(vector3.X * 3 - p1.X - p2.X,1), 
                                                    MathF.Round(vector3.Y * 3 - p1.Y - p2.Y,1)));
                case 4: // cuboid
                    return new Cuboid(vector3, new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1)));
                case 5: // cube
                    return new Cuboid(vector3, (float)Math.Round(rnd.NextDouble() * 10, 1));
                default: //sphere
                    return new Sphere(vector3, (float)Math.Round(rnd.NextDouble() * 10, 1));
            }
        }
    }
}