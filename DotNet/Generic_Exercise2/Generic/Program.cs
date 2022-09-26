using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            char[] h = s.ToCharArray();
            List<char> a = new List<char>();
            List<char> digits = new List<char>();
            for (int i = 0; i < h.Length; i++) {
                if (h[i] >= 'a' && h[i] <= 'z' || h[i]>='A' && h[i]<='Z')
                {
                    a.Add(h[i]);
                }
                else{
                    digits.Add((h[i]));
                }

            }
            a.Sort();
            digits.Sort();
            foreach (var val in a) {
                Console.Write(val);
                
            }
            Console.WriteLine();
            for (int i=0;i<digits.Count;i++)
            {
                Console.WriteLine(digits[i]);
                
            }



        }
    }
}
