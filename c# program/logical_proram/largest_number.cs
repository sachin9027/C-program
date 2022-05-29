using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
          if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("a is greater");
                }
                else
                {
                    Console.WriteLine("b is greater");
                }

            }
          else

            {
                if(b>c)
                {
                    Console.WriteLine("a is greater");
                }
                else
                {
                    Console.WriteLine("b is greater");
                }
            }
            Console.ReadLine();
        }
    }
}
