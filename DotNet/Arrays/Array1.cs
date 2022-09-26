using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements in array: ");
            for(int k =0; k<n; k++)
            {
                arr[k] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i< arr.Length; i++)
            {
                count++;
            }

            Console.WriteLine("Number of elements :{0}", count);
            
        }
    }
}
