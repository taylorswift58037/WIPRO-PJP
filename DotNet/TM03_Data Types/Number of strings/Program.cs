using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            String s = Console.ReadLine();

            int l = s.Length;
            var c1 = s.Count(x => Char.IsDigit(x));
            var c2 = s.Count(x => Char.IsLetter(x));
            Console.WriteLine("Length of the String is {0}",l);
            Console.WriteLine("Number of digits is {0}", c1);
            Console.WriteLine("Number of alphabets is {0}", c2);
            Console.ReadKey();


        }
    }
}
