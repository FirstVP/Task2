using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    abstract class Drawman
    {
        protected Panel drawPanel=null;

        protected Drawman(Panel drawPanel)
        {
            this.drawPanel = drawPanel;
        }

        public abstract void Draw<Type> (Type currentShape);


    }

   
    
}
