using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Fractal2.Models;
using System.Drawing;


namespace Fractal2
{
    public class Algoritm
    {
        public Point Calc(Point start, Point current)
        {
            
            decimal xNew =current.X + (start.X - current.X) / 2;
            decimal yNew = current.Y + (start.Y - current.Y) / 2;
            Point result = new Point((int)xNew, (int)yNew);
            return result;
        }
    }
}
