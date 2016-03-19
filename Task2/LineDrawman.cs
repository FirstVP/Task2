using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class LineDrawman: Drawman
    {
        public LineDrawman(Panel drawPanel)
            : base(drawPanel)
        {

        }

        public override void Draw<Shape>(Shape currentShape)
        {

            Line line = currentShape as Line;
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawLine(new Pen(Color.FromArgb(line._Colour)), line._CenterPoint.X, line._CenterPoint.Y, line._EndPoint.X, line._EndPoint.Y);
        }
    }
}
