using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_lesson
{
    class Program
    {
        static void Main()
        {
            double pi = 3.141592653d;
            decimal e = 4.65465464564654654654m;

            Console.Write("Number Pi equal: ");
            Console.WriteLine(pi);

            Console.Write("Num E is: ");
            Console.WriteLine(e);

            string a = "\nmy string1";
            string d = "\tмоя string2";
            string f = "\aмоя string3";

            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
