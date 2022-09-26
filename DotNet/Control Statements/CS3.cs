using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character: ");
            ch = char.Parse(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + " is a Special character.. ");
            }

            Console.ReadLine();
        }
    }
}
