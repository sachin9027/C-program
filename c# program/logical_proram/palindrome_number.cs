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
            Console.WriteLine("Enter the first number ");
            int num = int.Parse(Console.ReadLine());

            int result = 0;
            int rem;
            int temp = num;
            
            while(num!=0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;

            }
            num = temp;
                if(num==result)
            {
                Console.WriteLine("palindrome number ");
            }
                else
            {
                Console.WriteLine(" not an palindrome number");



            }
            
            Console.ReadLine();
        }
    }
}
