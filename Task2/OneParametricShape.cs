using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    abstract class OneParametricShape : Shape
    {
        protected int MainParameter;

        public int _MainParameter { get { return MainParameter; } }

        protected OneParametricShape(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            
        }

        
    }


    class Square : OneParametricShape
    {
        public Square(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            int mainParameter = secondPoint.X - firstPoint.X;

            this.MainParameter = mainParameter;
            this.CenterPoint.X = firstPoint.X + mainParameter / 2;
            this.CenterPoint.Y = firstPoint.Y + mainParameter / 2;
        }
   
    }



    class Circle : OneParametricShape
    {
        public Circle(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            int mainParameter = secondPoint.X - firstPoint.X;

            this.MainParameter = mainParameter;
            this.CenterPoint.X = firstPoint.X + mainParameter / 2;
            this.CenterPoint.Y = firstPoint.Y + mainParameter / 2;
        }
    
    }

    class EquilateralTriangle : OneParametricShape
    {

        public EquilateralTriangle(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            int mainParameter = (secondPoint.X - firstPoint.X) ;

            this.MainParameter = mainParameter;
            this.CenterPoint.X = firstPoint.X + mainParameter ;
            this.CenterPoint.Y = firstPoint.Y + mainParameter ;
        }

       
    }

}
