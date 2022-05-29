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
            Console.WriteLine("Enter the roll no:");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the standard:");
            int standard = int.Parse(Console.ReadLine());

            sachin.setstudent(rollno, name, age, standard);
            sachin.getstudent();
      
            Console.ReadLine();


        }
    }
}
