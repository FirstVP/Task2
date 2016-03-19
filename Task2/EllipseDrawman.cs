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

        public override void Draw(Point firstPoint, Point secondPoint)
        {
            Rectangle Rectangle = new Rectangle(firstPoint, secondPoint);
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.FromArgb(Rectangle._Colour)), Rectangle._CenterPoint.X - Rectangle._MainParameter / 2, Rectangle._CenterPoint.Y - Rectangle._SecondaryParameter / 2, Rectangle._MainParameter, Rectangle._SecondaryParameter);
        }
    }
}
