using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area_of_the_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of the side");
            string v = Console.ReadLine();
            int a = Convert.ToInt32(v);
            int s = a * a;
            Console.WriteLine("The Area of the square is {0}", s);
            Console.ReadKey();
        }
    }
}
