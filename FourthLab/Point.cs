using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLab
{
   public class Point
    {
        private double _x;
        private double _y;

        public double X => _x;

        public double Y => _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}
