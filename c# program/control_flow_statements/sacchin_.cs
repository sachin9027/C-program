using System;

namespace ConsoleApp36
{
    class a
    {
        private int age;
        public string name;
        public int first(int age)
        {
            this.age = age;
            Console.WriteLine(name);
            return this.age;
            Console.WriteLine("base class functiion");
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            a bj = new a();
            bj.name = "hjgjh";
            
            Console.WriteLine(bj.first(5));
            Console.WriteLine("Hello World!");
        }
    }
}
