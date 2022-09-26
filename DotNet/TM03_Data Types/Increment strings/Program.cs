using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Increment_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            char[] c=str.Select(x=>(Char)(x+1)).ToArray();
            Console.WriteLine(c);
            
            char[] c1 = str.ToArray();
            for(int i=0;i<str.Length;i++)
            {
                c1[i]++;
                Console.Write(c1[i]);
            }
            Console.ReadKey();
        }
    }
}
