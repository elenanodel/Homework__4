using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter any number and we calculate a factorial of your number!");
            Console.Write("Enter your number: ");

            double n = double.Parse(Console.ReadLine());
            double multiple = n;

            for (double i = 1; i < n; i++)
            {
                multiple = multiple * i;
            }
            Console.WriteLine("The result is: " + multiple);
            Console.ReadLine();
        }
    }
}
