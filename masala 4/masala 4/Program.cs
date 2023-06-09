using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            int L;
            d = Convert.ToDouble(Console.ReadLine());
            L = Convert.ToInt32(Math.PI * d);
            Console.WriteLine(L);
            Console.ReadKey();
            
        }
    }
}
