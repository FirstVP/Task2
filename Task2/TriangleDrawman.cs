using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class TriangleDrawman : Drawman
    {


        public TriangleDrawman(Panel drawPanel)
            : base(drawPanel)
        {

        }

        public override void Draw<Shape>(Shape currentShape)
        {
            EquilateralTriangle triangle = currentShape as EquilateralTriangle;

            const int pointCount = 3;

            int halfMainParameter = triangle._MainParameter / 2;

            Point[] points = new Point[pointCount];
            points[0] = new Point(triangle._CenterPoint.X, triangle._CenterPoint.Y - halfMainParameter);
            points[1] = new Point(triangle._CenterPoint.X - halfMainParameter, triangle._CenterPoint.Y + halfMainParameter);
            points[2] = new Point(triangle._CenterPoint.X + halfMainParameter, triangle._CenterPoint.Y + halfMainParameter);

            Graphics mainGrapics = drawPanel.CreateGraphics();

            Pen currentPen = new Pen(Color.FromArgb(triangle._Colour));

            mainGrapics.DrawLine(currentPen, points[0], points[1]);
            mainGrapics.DrawLine(currentPen, points[1], points[2]);
            mainGrapics.DrawLine(currentPen, points[2], points[0]);
        }
    }
}
