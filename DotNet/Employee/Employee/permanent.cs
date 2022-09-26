using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class permanent: Person, Ipayable
    {
        double HRA = 0, DA = 0, Tax = 0, Netpay=0, Total = 0;
        public double hra
        {
            get;set;
        }
        public double da
        {
            get; set;
        }
        public double tax
        {
            get; set;
        }
        public double netpay
        {
            get; set;
        }
        public double total
        {
            get; set;
        }
        public void Calculatepay()
        {
            Console.WriteLine(netpay);
        }

    }

}
