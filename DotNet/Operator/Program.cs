using System;

namespace PrePost
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the number: \n");
            num1 = Console.Read();

            num2 = ++num1;
            Console.WriteLine("\n Pre Increment: " + num2);


        }
    }
}
