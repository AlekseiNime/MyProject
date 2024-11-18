using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        

        static void Main()
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double b = Calculate(a);

            Console.WriteLine($"Значение функции для a = {a} равно b = {b}");
            Console.ReadKey();
        }
        static double Calculate(double a)
        {
            return 12 * a * a + 7 * a - 6;
        }
    }
}
