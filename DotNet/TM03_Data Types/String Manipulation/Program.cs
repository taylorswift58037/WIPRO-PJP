using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            String str = Console.ReadLine();
            //Reverse string
            char[] c = str.ToArray();
            Console.Write("The Reverse of the String is = ");
            for(int i=str.Length-1;i>=0; i--)
            {
                Console.Write(c[i]);
            }
            //    Array.Reverse(c);
            //    Console.WriteLine(" ");
            //    Console.WriteLine(c);

            //Sub String
            String substr = str.Substring(2);
            Console.WriteLine("\nThe Substring is = " + substr);

            //Replace string
            String rstr = str.Replace('a', '@').Replace('s','$');
            Console.WriteLine("The Replaced String is = " + rstr);

            //modify string
            String mstr = str.Substring(2).ToLower().Replace('i','1').Replace('o','*');
            Console.WriteLine("The old String is = " + str + " The modified String is = " + mstr);

            Console.ReadKey();
        }
    }
}
