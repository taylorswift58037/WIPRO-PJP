using System;

namespace Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int dig;

            Console.WriteLine("Enter the number :");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter the digit to be found: ");
            dig = int.Parse(Console.ReadLine());

            int count;
            count = 0;
            while(num > 0)
            {
                if( num%10 == dig)
                {
                    count++;
                }
                num = num / 10;
            }

            Console.WriteLine("No of occurences: " + count);
        }
    }
}
