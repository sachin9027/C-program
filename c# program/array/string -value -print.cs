using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] care = { "volvo", "bmw", "ford", "mazda" };
            Array.Sort(care);
            foreach(string i in care)
            {
                Console.WriteLine(i);
            }
            int[] myNum = { 4, 5, 7, 9 };
            Array.Sort(myNum);
            foreach(int i in myNum)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            
               
        }
    }
}
