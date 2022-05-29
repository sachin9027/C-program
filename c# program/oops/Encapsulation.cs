using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{

    class preson
    {
        private string name;
        private int age;

        public void setname(string name)
        {
            if(string.IsNullOrEmpty(name)==true)
            {
                Console.WriteLine("name is required..");
            }
            else
            {
                this.name = name;
            }
        }
        public void getname()
        {
            if (string.IsNullOrEmpty(name) == true)
            {

            }


            else
            {
                Console.WriteLine("your name is:" + this.name);
            }
        }
        public void setage(int age)
        {
            if(age>0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("age should not be negative or zero");

            }
        }
        public void getage()
        {
            if((age>0))
            {
                Console.WriteLine("your age is:" + this.age);
            }
            else
            {

            }
        }
        
    }
    class encapsulation
    {
        static void Main(string[] args)
        {
            preson obj = new preson();
            obj.setname("sachin");
            obj.getname();
            obj.setage(22 );
            obj.getage();
            Console.ReadLine();
        }
    }
}
 