using System;
using System.Collections.Generic;
using System.Text;

namespace STOCK
{
    class STOCK
    {
        private string name;
        private string model;
        private double pcprice;
        private double ccprice;
        
        public STOCK(string name,string model,double pcprice,double ccprice)
        {
            this.name = name;
            this.model = model;
            this.pcprice = pcprice;
            this.ccprice = ccprice;
        }

        public double getChangePercentage()
        {
            double pc = this.pcprice;
            double cc = this.ccprice;
            double change = Math.Abs(pc - cc)/pc*100;
            return change;

        }

        
    }
}
