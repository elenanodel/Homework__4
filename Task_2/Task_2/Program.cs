using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for calculate amount of deposit ");

            double money;
            int years;
            double deposit = 0;

            Console.Write("Enter your money contribution: ");
            money = int.Parse(Console.ReadLine());

            Console.Write("Enter amount of years: ");
            years = int.Parse(Console.ReadLine());

            for (int i = 1; i <= years; i++)
            {
                deposit = money + (20 * money) / 100;
                money += (20 * money) / 100;
            }
            Console.WriteLine(deposit);
            Console.ReadLine();
        }
    }
}
