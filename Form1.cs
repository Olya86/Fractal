using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            //formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
           

            //Point point1 = new Point(10, 10);
            //Point point2 = Point.Add(point1, new Size(0, 46));
            //formGraphics.DrawLine(Pens.Red, point1, point2);

            formGraphics.FillEllipse(Brushes.Green, new Rectangle(300, 50, 5, 5));
            formGraphics.FillEllipse(Brushes.Green, new Rectangle(150, 300, 5, 5));
            formGraphics.FillEllipse(Brushes.Green, new Rectangle(450, 300, 5, 5));

            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int x1 = rnd.Next(1, 3);
            formGraphics.FillEllipse(Brushes.Green, new Rectangle(450, 300, 5, 5));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        public class Point
        {
            private decimal _x;
            private decimal _y;

            public decimal X
            {
              get { return _x; }
              set { _x = value; }
            }

            public decimal Y
            {
                get { return _y; }
                set { _y = value; }
            }
        }



    }
}
