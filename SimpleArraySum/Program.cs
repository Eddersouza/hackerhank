﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int arr = Array.ConvertAll(arr_temp, Int32.Parse).Sum();

            Console.WriteLine(arr);

            Console.ReadKey();
        }
    }
}
