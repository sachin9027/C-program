using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class student
    {
        int rollno;
        string name;
        int age;
        int standard;

        public void setstudent(int rollno, string name, int age, int standard)
        {

            this.rollno = rollno; 
            this.name = name;
            this.age = age;
            this.standard = standard;

        }
        public void getstudent()
        {

            Console.WriteLine("your roll no is :{0}", this.rollno);
            Console.WriteLine("your name is :{0}", this.name);
            Console.WriteLine("your age is :{0}", this.age);
            Console.WriteLine("your class is :{0}", this.standard);
        }

        static void Main(string[] args)
        {
            student sachin = new student();
            sachin.setstudent(49, "sachin raj", 22, 15);
            sachin.getstudent();
      
            Console.ReadLine();


        }
    }
}
student value  class and objects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class student
    {
        int rollno;
        string name;
        int age;
        int standard;

        public void setstudent(int rollno, string name, int age, int standard)
        {

            this.rollno = rollno; 
            this.name = name;
            this.age = age;
            this.standard = standard;

        }
        public void getstudent()
        {

            Console.WriteLine("your roll no is :{0}", this.rollno);
            Console.WriteLine("your name is :{0}", this.name);
            Console.WriteLine("your age is :{0}", this.age);
            Console.WriteLine("your class is :{0}", this.standard);
        }

        static void Main(string[] args)
         {
            //    student sachin = new student();
            //    Console.WriteLine("Enter the roll no:");
            //    int rollno = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the name:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("enter the age:");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the class:");
            //    int standard = int.Parse(Console.ReadLine());

            student sachin = new student();

            sachin.setstudent(20, "sachin raj", 22,11);
            sachin.getstudent();
            Console.WriteLine("----------------");

            student nekpal = new student();
            nekpal.setstudent(24, "nekpal", 23, 12);
            sachin.getstudent();
            Console.WriteLine("-------------------");

            student rihan = new student();
            sachin.setstudent(50, "rihan", 20, 14);
            sachin.getstudent();
            Console.WriteLine("--------------------");

            student shrinivas = new student();
            shrinivas.setstudent(39, "shrinivas", 21, 15);
            sachin.getstudent();
            Console.WriteLine("----------------------------------");

            student pradeep = new student();
            sachin.setstudent(66,"pradeep kumar", 19,18);
            sachin.getstudent();
            Console.WriteLine("------------------------");

            student kuldeep = new student();
            sachin.setstudent(45, "kuldeep", 18, 5);
            sachin.getstudent();
            Console.WriteLine("--------------------");

            Console.ReadLine();


        }
    }
}







