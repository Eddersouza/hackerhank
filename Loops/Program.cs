using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int res = N * i;
                Console.WriteLine(string.Format("{0} x {1} = {2}",N.ToString(), i.ToString(),res.ToString()));
            }

            Console.ReadKey();
        }
    }
}
