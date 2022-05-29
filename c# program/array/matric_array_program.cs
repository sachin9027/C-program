using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3] {  { 10, 20, 30 },{ 40, 50, 60 } , { 70, 80, 90 }  };
           for(int a=0; a<arr.GetLength(0); a++)
            {
for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(" "+arr[a,j]);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
