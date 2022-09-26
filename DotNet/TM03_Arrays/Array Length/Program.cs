using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[] arr = new int[100];
            for(int i=0;i<10;i++)
            {
                arr[i] = i + 100;
            }
            for(int i=0;arr[i]!='\0';i++)
            {
                c++;
            }
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
