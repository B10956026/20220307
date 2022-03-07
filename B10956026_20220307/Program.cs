using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10956026_20220307
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100; //用餐費用
            int tip_percent = 15; //服務費
            int tax_percent = 8; //稅率

            Console.WriteLine("用餐費用=" + meal_cost);
            Console.WriteLine("服務費=" + tip_percent);
            Console.WriteLine("稅率=" + tax_percent);

            for (int i = 0; i < 20; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();

            int meal = (int)meal_cost;
            int sum = meal + tip_percent + tax_percent;

            Console.WriteLine("用餐總費用="+sum);

        }
    }
}
