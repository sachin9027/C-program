using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculter
{
    class Calculter
    {
        int num1;
        int num2;
        int result;

        void Addition()
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

        void multiplicatoin()
        {
            result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void division()
        {
            result = num1 / num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    


        static void Main(string[] args)
        {
            Calculter obj = new Calculter();
            obj.num1 = 60;
            obj.num2 = 30;
            obj.Addition();
            obj.subtract();
            obj.multiplicatoin();
            obj.division();


        }
    }
}
