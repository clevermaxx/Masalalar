using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kubning hajmi va to'la sirtini topish

            int a;
            double V, S;
            a = Convert.ToInt32(Console.ReadLine());
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
            Console.WriteLine(V);
            Console.WriteLine(S);
            Console.ReadKey();


        }
    }
}
