using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Task2
{

    public partial class MainForm : Form
    {
        bool IsActive = false;
        Point FirstPoint;
        Point SecondPoint;
        Drawman CurrentDrawman;
        FactoryShape CurrentFactory;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            IsActive = true;
            FirstPoint.X = e.X;
            FirstPoint.Y = e.Y;
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            Shape currentShape;

            SecondPoint.X = e.X;
            SecondPoint.Y = e.Y;
            

            if (IsActive)
                try
                {
                  currentShape = CurrentFactory.CreateShape(FirstPoint, SecondPoint);
                  CurrentDrawman.Draw(currentShape);
                }
                catch
                {
                    MessageBox.Show("Не выбрана фигура!");
                    
                }
                finally
                {
                   IsActive = false;
                }
           
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void toolStripButtonCircle_Click(object sender, EventArgs e)
        {
            CurrentFactory = new CircleShapeFactory();
            Factory current = new CircleFactory(pnlMain);
            CurrentDrawman = current.FactoryMethod();
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            CurrentFactory = new LineShapeFactory();
            Factory current = new LineFactory(pnlMain);
            CurrentDrawman = current.FactoryMethod();
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            CurrentFactory = new EllipseShapeFactory();
            Factory current = new EllipseFactory(pnlMain);
            CurrentDrawman = current.FactoryMethod();
        }

        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            CurrentFactory = new RectangleShapeFactory();
            Factory current = new RectangleFactory(pnlMain);
            CurrentDrawman = current.FactoryMethod();
        }

        private void toolStripButtonSquare_Click(object sender, EventArgs e)
        {
            CurrentFactory = new SquareShapeFactory();
            Factory current = new SquareFactory(pnlMain);
            CurrentDrawman = current.FactoryMethod();
        }

        private void toolStripButtonTriangle_Click(object sender, EventArgs e)
        {
            CurrentFactory = new TriangleShapeFactory();
            Factory current = new TriangleFactory(pnlMain);
            CurrentDrawman = current.FactoryMethod();
        }

       













    }
}
