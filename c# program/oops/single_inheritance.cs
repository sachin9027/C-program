using System;

namespace ConsoleApp39
{
    class car

    {
        string model;
        string color;
        int price;
       public void printCarInformation()
        {
            Console.WriteLine("model:" + model);
            Console.WriteLine("color:" + color);
            Console.WriteLine("price:" + price);
        }
        class maruti :car
        {
            float mileage;
            void printmileage()
            {
                Console.WriteLine("mileage:" + mileage);
            }
            static void Main(string[]args)
            {
                maruti mycar = new maruti();
                mycar.model = "alto";
                mycar.price = 20000000;
                mycar.color = "white";
                mycar.mileage = 80.79f;
                mycar.printCarInformation();
                mycar.printmileage();
                Console.ReadLine();
            }
        }
    }
}
