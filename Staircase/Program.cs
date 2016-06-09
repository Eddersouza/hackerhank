using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string t = string.Empty;

            for (int i = 0; i < n; i++)
            {
                t = t + "#";
                Console.WriteLine(t.PadLeft(n));
            }

            Console.ReadKey();
        }
    }
}
