using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Task2
{
    abstract class TwoParametricShape : OneParametricShape
    {
        protected int SecondaryParameter;

        public int _SecondaryParameter { get { return SecondaryParameter; } }

        protected TwoParametricShape(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {

        }


        public abstract override void Draw(Panel drawPanel);
    }

    class Rectangle : TwoParametricShape
    {


        public Rectangle(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            int mainParameter = secondPoint.X - firstPoint.X;
            int secondaryParameter = secondPoint.Y - firstPoint.Y;

            this.MainParameter = mainParameter;
            this.SecondaryParameter = secondaryParameter;
            this.CenterPoint.X = firstPoint.X + mainParameter / 2;
            this.CenterPoint.Y = firstPoint.Y + secondaryParameter / 2;

        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.FromArgb(Colour)), CenterPoint.X - MainParameter / 2, CenterPoint.Y - SecondaryParameter / 2, MainParameter, SecondaryParameter);
        }
    }
    class Ellipse : TwoParametricShape
    {
        public Ellipse(Point firstPoint, Point secondPoint)
            : base(firstPoint, secondPoint)
        {
            int mainParameter = secondPoint.X - firstPoint.X;
            int secondaryParameter = secondPoint.Y - firstPoint.Y;

            this.MainParameter = mainParameter;
            this.SecondaryParameter = secondaryParameter;
            this.CenterPoint.X = firstPoint.X + mainParameter / 2;
            this.CenterPoint.Y = firstPoint.Y + secondaryParameter / 2;

        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.FromArgb(Colour)), CenterPoint.X - MainParameter, CenterPoint.Y - SecondaryParameter, MainParameter * 2, SecondaryParameter * 2);
        }
    }
}
