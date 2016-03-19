using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class RectangleDrawman : Drawman
    {
        

        public RectangleDrawman(Panel drawPanel): base (drawPanel)
        {
           
        }

        public override void Draw<Shape>(Shape currentShape)
        {
            Rectangle rectangle = currentShape as Rectangle;
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.FromArgb(rectangle._Colour)), rectangle._CenterPoint.X - rectangle._MainParameter / 2, rectangle._CenterPoint.Y - rectangle._SecondaryParameter / 2, rectangle._MainParameter, rectangle._SecondaryParameter);
        }
    }
}
