using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4_Turning_UMLs_into_Code_Factory_Pattern_CSCI352
{
    internal class Program
    {
        enum ShapeType
        {
            LINE,
            CIRCLE,
            RECTANGLE,
            TRIANGLE           
        }
        interface IGeometricShape
        {
            void draw();
        }
        class Line : IGeometricShape
        {
            public void draw()
            {
                Console.WriteLine("Line is drawn.");
            }
        }
        class Circle : IGeometricShape
        {
            public void draw()
            {
                Console.WriteLine("Circle is drawn.");
            }
        }
        class Rectangle : IGeometricShape
        {
            public void draw()
            {
                Console.WriteLine("Rectangle is drawn.");
            }
        }
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
                    // not implemented
                    default:
                        return null;
                }
            }

        }
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            IGeometricShape shape;

            shape = factory.getShape(ShapeType.LINE);
            if (shape != null)
            {
                shape.draw();
            }
            else Console.WriteLine("Invalid shape");

            shape = factory.getShape(ShapeType.CIRCLE);
            if (shape != null)
            {
                shape.draw();
            }
            else Console.WriteLine("Invalid shape");

            shape = factory.getShape(ShapeType.RECTANGLE);
            if (shape != null)
            {
                shape.draw();
            }
            else Console.WriteLine("Invalid shape");

            shape = factory.getShape(ShapeType.TRIANGLE);
            if (shape != null)
            {
                shape.draw();
            }
            else Console.WriteLine("Invalid shape");

            Console.ReadKey();
        }
    }
}
