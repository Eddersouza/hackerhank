using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < n; i++)
            {
                d1 = a[i][i] + d1;
                d2 = a[i][n - i - 1] + d2;
            }

            int r = d1 - d2;

            if (r < 0)
            {
                r = r * -1;
            }

            Console.WriteLine(r);
        }
    }
}
