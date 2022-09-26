using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCII_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a alphabet or number");
                char c = Console.ReadLine()[0];
                if (char.IsDigit(c))
                {
                    Console.WriteLine("Its a number");
                }
                else if (char.IsLetter(c))
                {
                    Console.WriteLine("Its a alphabet");
                }
                else
                {
                    Console.WriteLine("Undefined Character");
                    break;
                }

            }
        }
    }
}
