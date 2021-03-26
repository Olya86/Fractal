using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
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
            Point pointD = new Point ( 400, 200 );
            Point pointA = new Point ( 300, 50 );
            Point pointB = new Point ( 150, 300 );
            Point pointC = new Point ( 450, 300 );

            formGraphics.FillEllipse(Brushes.Yellow, new Rectangle(pointD.X, pointD.Y, 2, 2));
            formGraphics.FillEllipse(Brushes.Green, new Rectangle(pointA.X, pointA.Y, 2, 2));
            formGraphics.FillEllipse(Brushes.Green, new Rectangle(pointB.X, pointB.Y, 2, 2));
            formGraphics.FillEllipse(Brushes.Green, new Rectangle(pointC.X, pointC.Y, 2, 2));

            Point pointCur = new Point(pointD.X, pointD.Y);

            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {

                //Получить случайное число (в диапазоне от 1 до 3)
                int pos = rnd.Next(1, 4);
                Debug.Print(pos.ToString());
                var al = new Algoritm();
                Point pointNew = al.Calc(pointA, pointA);
                switch (pos)
                {
                    case 1:
                        pointNew = al.Calc(pointA, pointCur);
                        break;
                    case 2:
                        pointNew = al.Calc(pointB, pointCur);
                        break;
                    case 3:
                        pointNew = al.Calc(pointC, pointCur);
                        break;
                }
                formGraphics.FillEllipse(Brushes.Red, new Rectangle(pointNew.X, pointNew.Y, 2, 2));
                pointCur.X = pointNew.X;
                pointCur.Y = pointNew.Y;
            }
           
            //  formGraphics.FillEllipse(Brushes.Green, new Rectangle(450, 300, 2, 2));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
       



    }
}
