using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class Line : Shape
    {
        Point EndPoint;

        public Point _EndPoint { get { return EndPoint; } }

        public Line(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            this.CenterPoint = firstPoint;
            this.EndPoint = secondPoint;
        }

    

    }
}
