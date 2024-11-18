using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        

        static void Main()
        {
            Console.WriteLine("Введите координаты первой вершины (x1, y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины (x2, y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты третьей вершины (x3, y3):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double a = CalculateDistance(x1, y1, x2, y2);
            double b = CalculateDistance(x2, y2, x3, y3);
            double c = CalculateDistance(x3, y3, x1, y1);

            double perimeter = CalculatePerimeter(a, b, c);
            Console.WriteLine("Периметр треугольника: " + perimeter);

            double area = CalculateArea(a, b, c);
            Console.WriteLine("Площадь треугольника: " + area);
        }
        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CalculateArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2; 
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
