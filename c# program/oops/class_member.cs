using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class car
    {
        string model;
        string color;
        int year;

        static void Main (string[]args)
        {
            car ford = new car();
            ford.model = "farari";
            ford.color = "blue";
            ford.year = 2009;

            car bmw = new car();
            bmw.model = "aodi";
            bmw.color = "white";
            bmw.year = 2020;
            Console.WriteLine(ford.model);
            Console.WriteLine(ford.model);
            Console.ReadLine();
        }
    }
}
  
      