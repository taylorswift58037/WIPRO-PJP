using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, sum = 0;

            Console.WriteLine("Enter " + 10 + " elements in the array: ");

            for (i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Adding all elements        
            for (i = 0; i < 10; i++)
            {
                sum = sum + arr[i]; // Calculating sum
            }

            Console.WriteLine("Sum of all elements of array: " + sum);

            Console.ReadLine();
        }
    }
}
