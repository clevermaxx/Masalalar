using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ikkita sonning o'rta arifmetigi aniqlansin;

            int a, b, arifmetigi;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            arifmetigi = (a + b) / 2;
            Console.WriteLine(arifmetigi);
            Console.ReadKey();

        }
    }
}
