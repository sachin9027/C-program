using System;

namespace ConsoleApp38
{
    class Program
    {
        public void Test()
            {
            Console.WriteLine(" public sachin kumar muskan saziya " );

            }
        private void Test1()
        {
            Console.WriteLine(" private sachin kumar muskan saziya ");
        }
        internal void Test2()

        {
            Console.WriteLine(" internal sachin kumar muskan saziya ");
        }
        protected void Test3()
        {
            Console.WriteLine("protected sachin kumar muskan saziya ");
        }
        protected internal void Test4()
        {
            Console.WriteLine(" protected internal sachin kumar muskan saziya ");
        }
       
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Test();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            Console.ReadLine();
        }
    }
}

using System;

namespace ConsoleApp38
{
    class Program
    {
       
        public void Test()
        {
            Console.WriteLine(" public sachin kumar muskan saziya ");

        }
        private void Test1()
        {
            Console.WriteLine(" private sachin kumar muskan saziya ");
        }
        internal void Test2()

        {
            Console.WriteLine(" internal sachin kumar muskan saziya ");
        }
        protected void Test3()
        {
            Console.WriteLine("protected sachin kumar muskan saziya ");
        }
        protected internal void Test4()
        {
            Console.WriteLine(" protected internal sachin kumar muskan saziya ");
        }
       
    }
    class Program1:Program
    {


        static void Main(string[] args)
        {

            Program1 obj = new Program1();
            obj.Test();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            Console.ReadLine();


        }

    }//on access pvivate class
}


persnt and chelid class

using System;

namespace ConsoleApp38
{
    class Program
    {
       
        public void Test()
        {
            Console.WriteLine(" public sachin kumar muskan saziya ");

        }
        private void Test1()
        {
            Console.WriteLine(" private sachin kumar muskan saziya ");
        }
        internal void Test2()

        {
            Console.WriteLine(" internal sachin kumar muskan saziya ");
        }
        protected void Test3()
        {
            Console.WriteLine("protected sachin kumar muskan saziya ");
        }
        protected internal void Test4()
        {
            Console.WriteLine(" protected internal sachin kumar muskan saziya ");
        }
       
    }
    class Program1:Program
    {


        static void Main(string[] args)
        {

            Program1 obj = new Program1();
            obj.Test();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            Console.ReadLine();


        }

    }
}
