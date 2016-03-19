using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    abstract class Shape
    {
        protected Point CenterPoint;
        protected int Colour;

        public Point _CenterPoint {get { return CenterPoint; } }
        public int _Colour { get { return Colour; } }

        protected Shape(Point firstPoint, Point secondPoint)
        {
           this.Colour = 0x78FF0000;
        }

        public abstract void Draw(Panel drawPanel);
    }

}
