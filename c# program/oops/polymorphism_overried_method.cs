
method overloading program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        public void add()
        {
            int a = 10;
            int b = 30;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(int a, int b)
        {
            
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(float a, float b)
        {
            
            
            float c = a + b;
            Console.WriteLine(c);
        }
        public void add(string a, string b)
        {
            
            
            string c = a+" "+ b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add();
            obj.add(25, 95);
            obj.add(4.5f, 7.8f);
            obj.add("sachin", "raj");
            Console.ReadLine();
        }
    }
}























method overriding program
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class car

    {

        public virtual void method()
        {
            Console.WriteLine("parents");



        }
        class child : car
        {
            public   override void method()

            {
                base.method();
                {
                    Console.WriteLine("expriment");
                }
               // Console.WriteLine("chld");
                


            }
        }
        class program

        {
            static void Main(string[] args)
            {
                car v= new child();
                v.method();
                Console.ReadLine();
            }
        }
    }
}   
