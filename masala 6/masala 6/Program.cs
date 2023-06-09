using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paralelepipedning hajmi va to'la sirtini topish.
            int a, b, c, V, S;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            V = a * b * c;
            S = 2 * (a * b + b * c + a * c);
            Console.WriteLine(V);
            Console.WriteLine(S);
            Console.ReadKey();

        }
    }
}
