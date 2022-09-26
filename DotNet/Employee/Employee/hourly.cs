using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class hourly : Person, Ipayable
    {

        public double HoursWorked { get;set;}
        public double PayPerHour { get; set; }
        public void Calculatepay()
        {
            double pay=0;
            pay = HoursWorked * PayPerHour;
            Console.WriteLine(pay);
        }
    }
}
