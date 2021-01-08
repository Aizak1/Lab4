using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FourthLab
{
   public class Triangle
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private double _perimetr;
        private double _square;
        private Point _medianPoint;

        public double Perimetr => _perimetr;

        public double Square => _square;

        public Point MedianPoint => _medianPoint;

        public Triangle(Point point1, Point point2, Point point3)
        {
            _firstSide = CalculateSide(point1, point2);
            _secondSide = CalculateSide(point2, point3);
            _thirdSide = CalculateSide(point1, point3);
            if (_firstSide > 0 && _secondSide > 0 && _thirdSide > 0)
            {

                if (_firstSide < (_secondSide + _thirdSide) && _secondSide < (_firstSide + _thirdSide) && _thirdSide < (_firstSide + _secondSide))
                {
                    _perimetr = CalculatePerimetr(_firstSide, _secondSide, _thirdSide);
                    _square = CalculateSquare(_firstSide, _secondSide, _thirdSide, _perimetr);
                    _medianPoint = CalculateMedianPoint(point1, point2, point3);
                }
                else
                {
                    throw new Exception("One side of triange should be less than sum of other two sides");
                }
            }
            else
            {
                throw new Exception("All sides of triangle should be greater than zero");
            }
      
            
            

        }
        public Triangle()
        {
            throw new Exception("You can't built triangle without points");
        }

        private double CalculateSide(Point point1,Point point2)
        {
            return Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
        }

        private double CalculateSquare(double firstSide, double secondSide, double thirdSide, double perimetr)
        {
            return Math.Sqrt(perimetr * (perimetr - firstSide) * (perimetr - secondSide) * (perimetr - thirdSide));
        }

        public double CalculatePerimetr(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }

        public Point CalculateMedianPoint(Point point1,Point point2,Point point3)
        {
            return new Point((point1.X + point2.X + point3.X) / 3, (point1.Y + point2.Y + point3.Y) / 3);
        }
        public void ShowInfoAboutSides()
        {
            Console.WriteLine("We have a triange with :");
            Console.WriteLine($"First side -> {_firstSide.ToString("F5")}");
            Console.WriteLine($"Second side -> {_secondSide.ToString("F5")}");
            Console.WriteLine($"Third side -> {_thirdSide.ToString("F5")}");
           
        }
    }
}
