using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List<string> usersPhone = new List<string>();
            int qtdRecords = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdRecords; i++)
            {
                string[] record = Console.ReadLine().Split(' ');
                phoneBook.Add(record[0], record[1]);
            }

            for (int i = 0; i < qtdRecords; i++)
            {
                usersPhone.Add(Console.ReadLine());
            }

            foreach (var item in usersPhone)
            {
                if (phoneBook.ContainsKey(item))
                {
                    Console.WriteLine(string.Format("{0}={1}",item, phoneBook[item]));
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            Console.ReadKey();
        }
    }
}
