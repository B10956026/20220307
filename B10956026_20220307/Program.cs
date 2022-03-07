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

            int sum = tip_percent + tax_percent;

            Console.WriteLine(sum);
        }
    }
}
