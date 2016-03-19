using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class CircleDrawman : Drawman
    {


        public CircleDrawman(Panel drawPanel)
            : base(drawPanel)
        {

        }

        public override void Draw<Shape>(Shape currentShape)
        {
            Circle circle = currentShape as Circle;
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.FromArgb(circle._Colour)), circle._CenterPoint.X - circle._MainParameter, circle._CenterPoint.Y - circle._MainParameter, circle._MainParameter * 2, circle._MainParameter * 2);
        }
    }
}
