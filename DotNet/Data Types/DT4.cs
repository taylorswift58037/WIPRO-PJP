using System;

namespace Upper_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            char[] arr1;
            int length, i;
            length = 0;
            char ch;
            Console.Write("Enter the string : ");
            str1 = Console.ReadLine();
            length = str1.Length;
            arr1 = str1.ToCharArray(0, length); 

            Console.Write("\nAfter conversion, the string is: ");
            for (i = 0; i < length; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) 
                    Console.Write(Char.ToUpper(ch)); 
                else
                    Console.Write(Char.ToLower(ch)); 
            }
            Console.ReadLine();
        }
    }
}
