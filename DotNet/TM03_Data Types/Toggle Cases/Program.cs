using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toggle_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter the String");
            String str= Console.ReadLine();
            char[] c = str.ToArray();
            char[] c1=new char[str.Length];
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsLower(c[i]))
                {
                    c1[i] = char.ToUpper(c[i]);
                }
                else if(char.IsUpper(c[i]))
                {
                    c1[i] = char.ToLower(c[i]);
                }
                else
                {
                    c1[i] = c[i];
                }
            }
            Console.WriteLine(c1);
            Console.ReadKey();

        }
    }
}
