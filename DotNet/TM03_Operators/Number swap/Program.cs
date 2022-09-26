using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1, str2;
            int n1, n2, temp;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            n1 = Convert.ToInt32(str1);
            n2 = Convert.ToInt32(str2);

            n2 = ++n1;
            Console.WriteLine("Pre-incrementing " + n1 + " " + n2);
            n2 = n1++;
            Console.WriteLine("Post-incrementing " + n1 + " " + n2);

            temp = n1;
            n1 = n2;
            n2 = temp;

            
            Console.WriteLine("After Swaping " + n1 + " " + n2);
            Console.ReadKey();
        }

    }
}
