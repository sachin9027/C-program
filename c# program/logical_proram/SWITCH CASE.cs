using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "y";
            Console.WriteLine("enter choce");
            int num = int.Parse(Console.ReadLine());
            switch (num)


            {
                case 1:
                    Console.WriteLine("tomoto price=40");
                    break;
                case 2:
                    Console.WriteLine("greenchilli price=40");
                    break;
                case 3:
                    Console.WriteLine("carott price=40");
                    break;
                case 4:
                    Console.WriteLine("guawa price=40");
                    break;
                case 5:
                    Console.WriteLine("Onion price=40");
                    break;
                case 6:
                    Console.WriteLine("defualt");
                    break;
                case 7:
                default:
                    Console.WriteLine("defualt");
                    break;
                     
            }
            {
                Console.WriteLine(" do you want conntinu y/no");
                string no = Console.ReadLine();
            } while (y == "y") ;
            Console.ReadLine(); 

        }
        

        

    
    }
   
}

    



   

