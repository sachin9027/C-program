using System;

namespace ConsoleApp37
{
    public class calculator
    {
        int num1;
        int num2;
        int result;
        void add()

        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void subtract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
         public static void Main(string[] args)
        {
            Console.WriteLine("sachin");
            calculator obj = new calculator();
                obj.num1 = 80;
            obj.num2 = 60;
            obj.add();
            obj.subtract();

           
        }
    }
}



using System;

namespace ConsoleApp37
{
    public class calculator
    {
        int num1;
        int num2;
        int result;
        void add()

        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void subtract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
         public static void Main(string[] args)
        {
            calculator obj = new calculator();
                obj.num1 = 80;
            obj.num2 = 160;
            obj.add();
            obj.subtract();

            calculator obj2 = new calculator();
            obj2.num1 = 60;
            obj2.num2 = 50;
            obj2.add();
            obj2.subtract();



        }
    }
}

