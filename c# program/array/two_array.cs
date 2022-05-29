using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 10;
            int[] z = new int[5];
            for(int i=0; i<5; i++)
            {
                z[i] = m;
                m = m + 10;
            }
            for (int i=0; i<5; i++)
            {
                Console.WriteLine(z[i]);
            }
            Console.ReadKey();
        }
       
    }
}
