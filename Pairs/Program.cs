using System;
using System.Linq;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] nk = Console.ReadLine().Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            int[] n = Console.ReadLine().Split(' ').Select(a => Convert.ToInt32(a)).ToArray();


                Console.WriteLine(pairs(n,nk[1]));

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);

            Console.ReadKey();
        }

        static int pairs(int[] a, int k)
        {
            int count = 0;
            int sizeList = a.Length;
                        
            for (int i = 0; i < sizeList; i++)
            {
                for (int i2 = 0; i2 < sizeList; i2++)
                {
                    if (a[i] - a[i2] == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
