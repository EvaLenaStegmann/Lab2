using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            int noOfShapes = 20;
            float totArea = 0.0f;
            float totCircumference = 0.0f;
            Shape3D biggest3D = null;

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < noOfShapes; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                totArea += shape.Area;
                if (shape is Triangle)
                {
                    totCircumference += (shape as Shape2D).Circumference;
                }

                if (shape is Shape3D && (biggest3D == null || (shape as Shape3D).Volume > biggest3D.Volume))
                {
                    biggest3D = shape as Shape3D;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Total omkrets för alla trianglar: {totCircumference:0.0}.");

            Console.WriteLine("");
            Console.WriteLine($"Genomsnittlig Area: {(totArea / noOfShapes):0.0}.");

            Console.WriteLine("");
            Console.WriteLine(value: $"Största 3D shape (volymmässigt) är: {biggest3D?.ToString()} som har volymen {biggest3D.Volume:0.0}.");
        }
    }
}
