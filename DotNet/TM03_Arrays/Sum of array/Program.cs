using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] arr = new int[10];
            for(int i=0;i<10;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
