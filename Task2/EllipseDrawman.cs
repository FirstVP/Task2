using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class EllipseDrawman : Drawman
    {


        public EllipseDrawman(Panel drawPanel)
            : base(drawPanel)
        {

        }

        public override void Draw<Shape>(Shape currentShape)
        {
            Ellipse ellipse = currentShape as Ellipse;
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.FromArgb(ellipse._Colour)), ellipse._CenterPoint.X - ellipse._MainParameter / 2, ellipse._CenterPoint.Y - ellipse._SecondaryParameter / 2, ellipse._MainParameter, ellipse._SecondaryParameter);
        }
    }
}
