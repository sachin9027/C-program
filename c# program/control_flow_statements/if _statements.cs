using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 40;
            int b = 50;
            int c = 60;
            if(a>b&a>c)
            {
                Console.WriteLine("A is the greatest");
            }
            else if(b>a&b>c)
            {
                Console.WriteLine("B is the greatest");

            }
            else
            {
                Console.WriteLine("C is the greatest");
            }
            Console.ReadLine();

        }
    }
}
