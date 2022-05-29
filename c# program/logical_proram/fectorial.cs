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
           int fect = 1;
            for (int i = 1; i <=5; i++)
            {
                fect= fect * i;
            }
            Console.WriteLine(fect);
            Console.ReadLine();

        }
    }
}


user se value fectorial
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter fect no");
            int num = int.Parse(Console.ReadLine());
            int fect = 1;
            
            for(int i=1; i<=num; i++)
            {
                fect = fect * i;

            }
            Console.WriteLine(fect);
            Console.ReadLine();
        }
    }
}

