using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revers_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "sachin", revers = "";
            int len;
            len = s.Length - 1;
            while(len>=0)
            {
                revers = revers + s[len];
                len--;
            }
            Console.WriteLine(revers);
            Console.ReadLine();
        }
    }
}
second logic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string ");
            string s = Console.ReadLine();
            Console.WriteLine("reverse string=");
            for (int i=(s.Length-1); i>=0; i--)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadLine();
            
        }
    }
}

