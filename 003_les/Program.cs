using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_les
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            Console.WriteLine("first equation = {0}, \nsecond = {1}", x += y - x++ * z, z = --x - y * 5);
            Console.WriteLine("third = {0}", y /= x + 5 % z);
            Console.WriteLine("fourth = {0}", z = x++ + y * 5);
            Console.WriteLine("fifth = {0}", x = y - x++ * z);

            Console.WriteLine(new string('-', 65));
            //middle arithmetic
            double a = 5, b = 10, c = 20, rez = 0;
            rez = (a + b + c) / 3;
            Console.WriteLine("\nmiddle arithmethic = {0} and {1} and {2}, equal {3}", a, b, c, rez);

            Console.WriteLine(new string('.', 65));
            const float pi = 3.141f;
            int r = 15, h = 14;

            Console.WriteLine("\nAREA {0}", (pi * r * r));//
            Console.WriteLine("Сylinder capacity {0}", (pi * r * r * h));
            Console.WriteLine("the surface area of the cylinder {0}", (2 * pi * r * (r + h)));

            Console.WriteLine(new string('+', 65));
            //arithmetic operation

            int q = 9, w = 3;
            Console.WriteLine("\naddition (+) = {0}", q + w);
            Console.WriteLine("Subtraction (-) = {0}", q - w);
            Console.WriteLine("Multiplication (*) = {0}", q * w);
            Console.WriteLine("Division (/) = {0}", q / w);
            Console.WriteLine("Remainder after division (%) = {0}", q % w);




            Console.ReadKey();

        }
    }
}
