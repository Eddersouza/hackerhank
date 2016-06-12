using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Array.Reverse(arr);

            string[] arrStr = arr.Select(x => x.ToString()).ToArray();
            
            Console.WriteLine(string.Join(" ", arrStr));
        }
    }
}
