using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            double mealPriceTip = mealCost * (double)tipPercent / 100;
            double mealPriceTax = mealCost * (double)taxPercent / 100;

            double totalCost = Math.Round(mealCost + mealPriceTip + mealPriceTax, MidpointRounding.AwayFromZero);

            Console.WriteLine(string.Format("The total meal cost is {0} dollars.", totalCost));
        }
    }
}
