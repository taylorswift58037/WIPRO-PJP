using System;

namespace String_Incre
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            char[] arr1;
            Console.Write("Enter String : ");
            str1 = Console.ReadLine();
            char ch;
            arr1 = str1.ToCharArray(0, str1.Length);

            string str;
            str = "\0";
            
            for( int i=0; i< str1.Length; i++)
            {
                ch = arr1[i];
                str = str + (char)(ch+1);                
            }
            Console.Write(str);
            Console.ReadLine();
        }
    }
}
