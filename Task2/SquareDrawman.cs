using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    class SquareDrawman : Drawman
    {


        public SquareDrawman(Panel drawPanel)
            : base(drawPanel)
        {

        }

        public override void Draw<Shape>(Shape currentShape)
        {
            Square square = currentShape as Square;
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.FromArgb(square._Colour)), square._CenterPoint.X - square._MainParameter, square._CenterPoint.Y - square._MainParameter, square._MainParameter * 2, square._MainParameter * 2);
        }
    }
}
