using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ikkita sonning o'rta geometrigi aniqlansin
            int a, b;
            double geometrigi;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            geometrigi = Math.Sqrt(a * b);
            Console.WriteLine(geometrigi);
            Console.ReadKey();

        }
    }
}
