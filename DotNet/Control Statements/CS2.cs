using System;

namespace Digit_Present
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

            int count = 0;
            while (num > 0)
            {
                if (num % 10 == dig)
                {
                    break;
                }
                num = num / 10;
                count++;
            }
            if(count == 0)
            {
                Console.WriteLine("Digit Found at One's Place ");
            }
            else if(count == 1)
            {
                Console.WriteLine("Digit Found at Ten's Place ");
            }
            else if(count == 2)
            {
                Console.WriteLine("Digit Found at Hundred's Place ");
            }
            else
            {
                Console.WriteLine("Digit Found at Thousand's Place ");
            }
        }
    }
}
