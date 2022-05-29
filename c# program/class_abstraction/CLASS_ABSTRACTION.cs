using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstraction
{
    abstract class person
    {

        public string FirstName;
        public string LastName;
        public int age;
        public string PhoneNumber;

        public abstract void printDetails();
    }
    class student : person
    {
        public int RollNo;

        public int Fees;
        public override void printDetails()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine("student name is:{0}", name);
            Console.WriteLine("student age is:{0}", age);
            Console.WriteLine("student PhoneNumber is:{0}", PhoneNumber);
            Console.WriteLine("student RollNo is:{0}", RollNo);
            Console.WriteLine("student Fees is:{0}", Fees);


        } 

        
    }
    class teacher:person
    {
        public string qualification;
        public int salary;
        public override void printDetails()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine("teacher name is:{0}", name);
            Console.WriteLine("teacher age is:{0}", age);
            Console.WriteLine("teacher PhoneNumber is:{0}", PhoneNumber);
            Console.WriteLine("teacher qualification is:{0}", qualification);
            Console.WriteLine("teacher salary is:{0}", salary);


        }
    }
    class program
    { 
        

        static void Main(string[] args)
        {
            student obj = new student();
            obj.FirstName = "sachin";
            obj.LastName = "Raj";
            obj.age = 21;
            obj.PhoneNumber = "9027028974";
            obj.RollNo = 19130167;
            obj.Fees = 48000;
            obj.printDetails();
            Console.WriteLine("----");

            teacher obj1 = new teacher();
            obj1.FirstName = "shishpal";
            obj1.LastName = "Gola";
            obj1.age = 25;
            obj1.PhoneNumber = "9027028974";
            obj1.qualification ="master in math" ;
            obj1.salary = 48000;
            obj1.printDetails();
            Console.ReadLine();
        }
    }
}
