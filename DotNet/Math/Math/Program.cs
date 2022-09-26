using System;
namespace Math
{
    class Program
    {
        public static int add(int a,int b)
        {
            return (a + b);
        }
        public static int add(int a,int b,int c)
        {
            return a + b + c;
        }
        public static int mul(int a, int b)
        {
            return a *b;
        }
        public static int mul(int a, int b, int c)
        {
            return a *b* c;
        }
        public static int sub(int a, int b)
        {
            return (a - b);
        }
        public static int sub(int a, int b,int c)
        {
            return a-b-c;
        }
        public static int div(int a, int b, int c)
        {
            return a / b / c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(1,2));
            Console.WriteLine(add(2,4,5));
            Console.WriteLine(mul(1, 2));
            Console.WriteLine(mul(3,4,5));
            Console.WriteLine(sub(3,2));
            Console.WriteLine(sub(10, 2,2));
            Console.WriteLine(div(3, 3,1));
        }
    }
}
