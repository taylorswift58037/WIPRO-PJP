using System;

namespace Data_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int length = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            length = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (length >= 0)
            {
                Console.Write(str[length]);
                length--;
            }

            int i = 1;
            Console.Write("\n The characters from 2nd till end: \n");
            while( i < str.Length)
                {
                    Console.Write(str[i]);
                i++;
                }

            length = str.Length;
            string[] str2 = new string[length];

            i = 0;
            string str3 ;
            str3 = "\0";
            Console.Write("\n Replace any character by $: \n");
            while(i < str.Length)
            {
                char ch = str[i];
                ch = '$';
                str3 = str3 + (char)(ch);
                i++;
            }
            Console.Write(str3);

            i = 0;
            while (i < length)
            {
                string tmp = str[i].ToString();
                str2[i] = tmp;
                i++;
            }
            Console.Write("\nThe First string is : {0}\n", str);
            Console.Write("The Second string is : {0}\n", string.Join("", str2));

            Console.ReadLine();
        }
    }
}
