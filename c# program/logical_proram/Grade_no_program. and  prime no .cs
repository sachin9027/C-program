using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class MyApp
    {
        int s = 0;
        public int sum(int[]x)
        {
            foreach(int a in x)
            {
                s +=a;
            }
            Console.WriteLine("total {0}", s);
            return s;
        }
        public void grade (int g)
        {
            if(g>=200)
            {
                Console.WriteLine("A");
            }
            else if(g>=150)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 450, 560, 180, 90 };
            MyApp obj = new MyApp();
            int value = obj.sum(data);
            obj.grade(value);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            for (int a = 1; a <= 10; a++);
            {
                if (a % 2 == 0)

                {
                    Console.WriteLine("even=" + a);
                }
          
                    Console.WriteLine("odd no=" + a);
                
            }
        }
    }
}

