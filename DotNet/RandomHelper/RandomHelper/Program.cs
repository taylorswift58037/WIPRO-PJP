using System;

namespace RandomHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RandomHelper.randint(min,max));
            Console.WriteLine(RandomHelper.randdouble(min, max));
        }
    }
}
