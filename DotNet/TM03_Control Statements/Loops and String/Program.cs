using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1;
            str1 = Console.ReadLine().ToLower();

            palindrome(str1);
            Console.ReadKey();
        }
        static void palindrome(string s1)
        {
            int i, j, t=0;
            char[] c1 = s1.ToArray();

            for (i = 0, j = s1.Length - 1; (i < s1.Length) && (j >= 0); i++, j--)
            {

                    if(c1[i]==c1[j])
                    {
                        continue;
                    }
                    else
                    {
                        t = 1;
                        break;
                    }
              
            }
            if(t==0)
            {
                Console.WriteLine("Its a palindrome");
            }
            else if(t==1)
            {
                Console.WriteLine("It is not a Palindrome");
            }

        }
    }
}
