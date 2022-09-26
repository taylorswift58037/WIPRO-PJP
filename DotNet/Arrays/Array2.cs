using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i;

            //Reads elements in array
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Print array in reversed order
            Console.WriteLine("\nArray in reverse order: ");
            for (i = 9; i >= 0; i--)
            {
                Console.Write("\t" + array[i]);
            }

            Console.ReadLine();
        }
    }
}
