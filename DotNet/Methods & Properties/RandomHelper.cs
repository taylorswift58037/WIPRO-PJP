using System;
using System.Collections.Generic;
using System.Text;

namespace RandomHelper
{
    class RandomHelper
    {
        public static int randint(int a,int b)
        {
            Random num = new Random();
            return num.Next(a, b);
        }
        public static double randdouble(double a,double b)
        {
            Random num = new Random();
            return num.NextDouble()*(b-a)+a;
        }
    }
}
