using System;

namespace SortTheSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            char[] arr1;
            char ch;
            int i, j, length;
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            length = str.Length;
            arr1 = str.ToCharArray(0, length);

            for (i = 1; i < length; i++)
                for (j = 0; j < length - i; j++)

                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
            Console.Write("After sorting the string appears like : \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.ReadLine();
        }
    }
}
