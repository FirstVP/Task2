using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Task2
{
    abstract class FactoryShape
    {
        

        public FactoryShape()
        {
            
        }

        public abstract Shape CreateShape(Point firstPoint, Point secondPoint);
    }
    class RectangleShapeFactory : FactoryShape
    {
        public RectangleShapeFactory()
            
        {
            
        }
        public override Shape CreateShape(Point firstPoint, Point secondPoint) { return new Rectangle(firstPoint, secondPoint); }
    }

    class EllipseShapeFactory : FactoryShape
    {
        public EllipseShapeFactory()
          
        {

        }
        public override Shape CreateShape(Point firstPoint, Point secondPoint) { return new Ellipse(firstPoint, secondPoint); }
    }

    class LineShapeFactory : FactoryShape
    {
        public LineShapeFactory()
          
        {

        }
        public override Shape CreateShape(Point firstPoint, Point secondPoint) { return new Line(firstPoint, secondPoint); }
    }

    class CircleShapeFactory : FactoryShape
    {
        public CircleShapeFactory()
            
        {

        }
        public override Shape CreateShape(Point firstPoint, Point secondPoint) { return new Circle(firstPoint, secondPoint); }
    }

    class SquareShapeFactory : FactoryShape
    {
        public SquareShapeFactory()
           
        {

        }
        public override Shape CreateShape(Point firstPoint, Point secondPoint) { return new Square(firstPoint, secondPoint); }
    }

    class TriangleShapeFactory : FactoryShape
    {
        public TriangleShapeFactory()
           
        {

        }
        public override Shape CreateShape(Point firstPoint, Point secondPoint) { return new EquilateralTriangle(firstPoint, secondPoint); }
    }
}





