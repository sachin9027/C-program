using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Enter A String");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reverse = new string(arr);

            if(str.ToLower().Equals(str_reverse.ToLower()))
            {
                Console.WriteLine("Its A Palindrome String....");
            }
            else
            {
                Console.WriteLine("Its Not A Palindrome String....");
            }
            Console.ReadLine();
        }
    }
}
