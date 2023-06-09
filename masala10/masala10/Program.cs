using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala10
{
    class Program
    {
        static void Main(string[] args)
        {
            // ikkita sonning yigindisi, kupaytmasi va kvadratining toping  
            int a, b, yigindisi, kupaytmasi, kvadrati1, kvadrati2;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            yigindisi = a + b;
            kupaytmasi = a * b;
            kvadrati1 = a * a;
            kvadrati2 = b * b;
            Console.WriteLine(yigindisi);
            Console.WriteLine(kupaytmasi);
            Console.WriteLine(kvadrati1);
            Console.WriteLine(kvadrati2);
            Console.ReadKey();





        }
    }
}
