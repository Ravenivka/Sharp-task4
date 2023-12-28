using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите натуральное число");
            string userInput= Console.ReadLine();
            int number=Int32.Parse(userInput);
            if (number < 1)
            {
                Console.WriteLine("Число не натуральное");
            }
            else
            {
                Console.WriteLine("oops");
            }
        }
    }
}
