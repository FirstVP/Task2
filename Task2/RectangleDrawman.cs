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
        Rectangle Rectangle;

        public RectangleDrawman(Panel drawPanel): base (drawPanel)
        {
           
        }

        protected override void CreateObject(Point firstPoint, Point secondPoint)
        {
            int mainParameter = secondPoint.X - firstPoint.X;
            int secondParameter = secondPoint.Y - firstPoint.Y;
            int firstCentralCoordinate = firstPoint.X + mainParameter / 2;
            int secondCentralCoordinate = firstPoint.Y + secondParameter / 2;

            this.Rectangle = new Rectangle(firstCentralCoordinate, secondCentralCoordinate, mainParameter, secondParameter, 0x78FF0000);
        }

        public override void Draw(Point firstPoint, Point secondPoint)
        {
            CreateObject (firstPoint, secondPoint);
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.FromArgb(Rectangle._Colour)), Rectangle._CenterPoint.X - Rectangle._MainParameter / 2, Rectangle._CenterPoint.Y - Rectangle._SecondaryParameter / 2, Rectangle._MainParameter, Rectangle._SecondaryParameter);
        }
    }
}
