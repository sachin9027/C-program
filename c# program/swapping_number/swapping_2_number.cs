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
            int a = 75;
            int b = 84;
            int t = a;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("values after swapping:");
            Console.WriteLine("a is :" +a);
            Console.WriteLine("b is :" +b);
            Console.ReadLine();
        }
    }
}

second Program
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
            string a, b;
            int temp, c, d;
            Console.Write("Enter value for a:");
            a = Console.ReadLine();
            c = Convert.ToInt32(a);
            Console.WriteLine("A's value is {0}", c);
            Console.Write("Enter value for b:");

            b = Console.ReadLine();
            d = Convert.ToInt32(b);
            Console.WriteLine("B's value is {0}", d);
            temp = c;
            c = d;
            d = temp;
            Console.WriteLine("value after swapping are:");
            Console.WriteLine("a is :" +d);
            Console.ReadLine();
        }
    }
}


Two number swapping
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, temp;
            Console.WriteLine("Enter the first number");
             num=int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the second number");
            num2=int.Parse(Console.ReadLine());
            temp = num;
            num = num2;
            num2 = temp;
            Console.WriteLine("After the swapping number");
            Console.WriteLine("first number is =" + num);
            Console.WriteLine("second number is =" + num2);
            Console.ReadLine();


        }
    }
}

            
