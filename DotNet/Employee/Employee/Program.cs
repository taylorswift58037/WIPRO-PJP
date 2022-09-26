using System;
using System.Collections.Generic;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            permanent P1 = new permanent();
            P1.firstn = "Muhilan";
            P1.lastn = "S";
            hourly h1 = new hourly();
            h1.firstn = "Bob";
            h1.lastn = "joe";
            h1.HoursWorked = 50;
            h1.PayPerHour = 100;
            h1.Calculatepay();
        }
    }
}
