using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doiraning uzunligi va yuzasini topish;
            int R;
            Double L, S;
            R = Convert.ToInt32(Console.ReadLine());
            L = 2 * Math.PI * R;
            S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine(L);
            Console.WriteLine(S);
            Console.ReadKey();

        }
    }
}
