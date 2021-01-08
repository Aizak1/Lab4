using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of trianges tops to create a triange");
            string userInput = "";
            while (userInput!="exit")
            {
                #region Enter initial Data
                Console.Write("Enter x1 -> ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("Enter y1 -> ");
                int y1 = int.Parse(Console.ReadLine());
                Console.Write("Enter x2 -> ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Enter y2 -> ");
                int y2 = int.Parse(Console.ReadLine());
                Console.Write("Enter x3 -> ");
                int x3 = int.Parse(Console.ReadLine());
                Console.Write("Enter y3 -> ");
                int y3 = int.Parse(Console.ReadLine());
                #endregion
                Triangle triangle = new Triangle(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3));
                triangle.ShowInfoAboutSides();
                ShowMainProperites(triangle);
                Console.WriteLine();
                Console.WriteLine("If you want to exit enter \'exit\'");
                Console.WriteLine("If you want to create new Triange enter any other symbol");
                userInput = Console.ReadLine();
                Console.Clear();
            }
           
        }

        private static void ShowMainProperites(Triangle triangle)
        {
            Console.WriteLine($"Perimetr -> {triangle.Perimetr.ToString("F5")}");
            Console.WriteLine($"Square -> {triangle.Square.ToString("F5")}");
            Console.WriteLine($"MedianPoint ->({triangle.MedianPoint.X.ToString("F5")},{triangle.MedianPoint.Y.ToString("F5")})");
        }
    }
}
