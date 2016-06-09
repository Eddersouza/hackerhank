using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int count = arr.Length;

            double maz = 0;
            double z = 0;
            double mez = 0;

            maz = arr.Count(x => x > 0);
            z = arr.Count(x => x == 0);
            mez = arr.Count(x => x < 0);

            double r1 = (maz * 100) / n;
            double r2 = (mez * 100) / n;
            double r3 = (z * 100) / n;

            Console.WriteLine(string.Format("{0:N6}", r1 / 100));
            Console.WriteLine(string.Format("{0:N6}", r2 / 100));
            Console.WriteLine(string.Format("{0:N6}", r3 / 100));
            Console.ReadKey();
        }
    }
}
