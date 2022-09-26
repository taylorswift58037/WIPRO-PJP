using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1, str2;
            int num1, num2, temp, c = 0, t = 0;
            Console.WriteLine("Enter the two numbers");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            num1 = Convert.ToInt32(str1);
            num2 = Convert.ToInt32(str2);

            do
            {
                temp = num1 % 10;
                c = c + 1;
                if (num2 == temp)
                {
                    t = c;
                    break;
                }
                num1 = num1 / 10;
            } while (num1 > 0);

            if (t == 1)
            {
                Console.WriteLine("Its in unit's position");
            }
            else if (t == 2)
            {
                Console.WriteLine("Its in Ten's position");
            }
            else if (t == 3)
            {
                Console.WriteLine("Its in Hundred's position");
            }
            else if (t == 4)
            {
                Console.WriteLine("Its in Thousand's position");
            }
            else
            {
                Console.WriteLine("The number is not present in any of the positions");
            }
            Console.ReadKey();
        }
    }
}
