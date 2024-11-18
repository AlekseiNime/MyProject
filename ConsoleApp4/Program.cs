using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        

        static void Main()
        {
            Console.Write("Введите первое целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = Add(a, b);
            int difference = Subtract(a, b);
            int product = Multiply(a, b);
            double quotient = Divide(a, b);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {difference}");
            Console.WriteLine($"Произведение: {product}");

            if (!double.IsNaN(quotient))
            {
                Console.WriteLine($"Частное: {quotient}");
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
                return double.NaN;  
            }
            return (double)a / b;
        }
    }
}
