using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01.Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceUs = decimal.Parse(Console.ReadLine());
            var weightUs = uint.Parse(Console.ReadLine());
            var priceUk = decimal.Parse(Console.ReadLine());
            var weightUk = uint.Parse(Console.ReadLine());
            var priceCh = decimal.Parse(Console.ReadLine());
            var weightCh = uint.Parse(Console.ReadLine());

            var storeUs = (double)(priceUs/ weightUs) / 0.58;
            var storeUk = (double)(priceUk / weightUk) / 0.41;
            var storeCh = (double)(priceCh / weightCh) * 0.27;
            if  (storeUs < storeUk && storeUs < storeCh)
            {
                Console.WriteLine($"US store. {storeUs:f2} lv/kg");
                Console.WriteLine($"Difference {Math.Max(storeCh, storeUk) - storeUs:f2} lv/kg");
            }
            if (storeUk < storeUs && storeUk < storeCh)
            {
                Console.WriteLine($"UK store. {storeUk:f2} lv/kg");
                Console.WriteLine($"Difference {Math.Max(storeUs, storeCh) - storeUk:f2} lv/kg");
            }
            if (storeCh < storeUs && storeCh < storeUk)
            {
                Console.WriteLine($"Chinese store. {storeCh:f2} lv/kg");
                Console.WriteLine($"Difference {Math.Max(storeUs, storeUk) - storeCh:f2} lv/kg");
            }
        }
    }
}
