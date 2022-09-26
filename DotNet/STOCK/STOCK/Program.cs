using System;

namespace STOCK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Stock Details");
            STOCK s1 = new STOCK("Asian Paints Ltd.", "Classic",1823.37, 1846.18);
            Console.WriteLine("Change Percentage {0}%", Math.Round(s1.getChangePercentage(),2));
        }
    }
}
