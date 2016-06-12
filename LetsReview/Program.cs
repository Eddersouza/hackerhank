using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> texts = new List<string>();
           
            int qtdCase = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qtdCase; i++)
            {
                texts.Add(Console.ReadLine());   
            }

            foreach (var item in texts)
            {
                string textOdd = string.Empty;
                string textEven = string.Empty;

                for (int i = 0; i < item.Length; i++)
                {
                    if (i >= 0 && i % 2 == 0)
                    {
                        textOdd += item[i];
                    }
                    else
                    {
                        textEven += item[i];
                    }
                }

                Console.WriteLine(string.Format("{0} {1}", textOdd, textEven));
            }
                       

            Console.ReadKey();
        }
    }
}
