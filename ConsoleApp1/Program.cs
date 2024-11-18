using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Bye();
            Console.ReadKey();
        }

        static void Hello()
        {
            Console.WriteLine("Привет");
        }
        static void Bye()
        {
            Console.WriteLine("Пока");
        }
    }
}
