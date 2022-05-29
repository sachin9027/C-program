using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            string y="";
            do
            {
                Console.WriteLine("Enter your name");
                int s = int.Parse(Console.ReadLine());

                if (s % 2 == 0)
                {
                    Console.WriteLine("I am sachin raj ");
                }
                else
                {
                    Console.WriteLine("I am not sachin raj");
                }
                Console.WriteLine("do want continue y/n");
                string no = Console.ReadLine();
            }
            while (y == "y");
        }
    }
}
