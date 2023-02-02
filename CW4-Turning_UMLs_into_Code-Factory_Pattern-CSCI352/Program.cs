// Name: Zachary Rose
// Date: 1/27/2023
// Class: CSCI352
// Simple console program based off of the concrete shape factory UML
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CW4_Turning_UMLs_into_Code_Factory_Pattern_CSCI352
{
    internal class Program
    {
        // Possible shape types. Triangle not implemented by design.
        enum ShapeType
        {
            LINE,
            CIRCLE,
            RECTANGLE,
            TRIANGLE           
        }
        // Geometric shapes must be drawable
        interface IGeometricShape
        {
            void draw();
        }
        // A line shape
        class Line : IGeometricShape
        {
            public void draw()
            {
                Console.WriteLine("Line is drawn.");
            }
        }
        // A circle shape
        class Circle : IGeometricShape
        {
            public void draw()
            {
                Console.WriteLine("Circle is drawn.");
            }
        }
        // A rectangle shape
        class Rectangle : IGeometricShape
        {
            public void draw()
            {
                Console.WriteLine("Rectangle is drawn.");
            }
        }
        // ShapeFactory class, can return the specified IGeometricShape based on the requested ShapeType
        class ShapeFactory
        {
            public IGeometricShape getShape(ShapeType type)
            {
                switch (type)
                {
                    case ShapeType.LINE:
                        return new Line();
                    case ShapeType.CIRCLE:
                        return new Circle();
                    case ShapeType.RECTANGLE:
                        return new Rectangle();
                    // non implemented shape
                    default:
                        return null;
                }
            }

        }
        // Uses ShapeFactory to make a shape of every available ShapeType and calls their draw method, if they are implemented.
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            IGeometricShape shape;

            foreach (ShapeType n in Enum.GetValues(typeof(ShapeType))){
                shape = factory.getShape(n);
                if (shape != null)
                {
                    shape.draw();
                }
                else Console.WriteLine("Invalid shape");
            }
            
            Console.ReadKey();
        }
    }
}
