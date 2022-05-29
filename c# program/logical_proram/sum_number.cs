using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum = 0;
            for (int i = 1; i <=5; i++)
            {
                sum= sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
