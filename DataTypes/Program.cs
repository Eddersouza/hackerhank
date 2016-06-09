using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0f;
            string s = "HackerHank";

            int i2 = Convert.ToInt32(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            string s2 = Console.ReadLine();

            int i3 = i + i2;
            double d3 = d + d2;
            Console.WriteLine(i3);
            Console.WriteLine(string.Format("{0:N1}",d3));
            Console.WriteLine(string.Format("{0} {1}", s, s2));

            Console.ReadKey();
        }
    }
}
