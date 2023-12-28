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
            int A;
            int B;
            int C;
            string D = "";
            Console.WriteLine("Введите натуральное число");
            string userInput= Console.ReadLine();
            int number=Int32.Parse(userInput);
            if (number < 1)
            {
                Console.WriteLine("Число не натуральное");
            }
            else
            {
                 C = number;
                int razriadnost = userInput.Length;
                int i = 0;
                while (i < razriadnost)
                {
                    A = C % 10;
                    C = C / 10;
                    i = i + 1;
                    D = A + ", "+D;
                }
                //D = D.TrimEnd(',');
                D = D.Trim();
                D = D.TrimEnd(',');
                Console.WriteLine(D);
            }
        }
    }
}
