using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            bool even = number % 2 == 0;

            string res = string.Empty;

            if (number>20 && even)
            {
                res = "Not Weird";
            }
            else if (number >=6 && number <= 20 && even)
            {
                res = "Weird";
            }
            else if (number >=2 && number <= 5 && even)
            {
                res = "Not Weird";
            }
            else
            {
                res = "Weird";
            }

            Console.WriteLine(res);
        }
    }
}
