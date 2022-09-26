using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_of_occurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1=Console.ReadLine();
            String str2 = Console.ReadLine();
            int c=0;
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);

            while(num1>0)
            {
                if(num1%10==num2)
                {
                    c = c + 1;
                }
                num1= num1 / 10;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
