using System;

namespace Salary
{
    class empsalary
    {
        String Name;
        double Basepay,HRA,GROSS,DA,TAX,NetPay;

        public void caldetails(String name,double bas)
        {
            this.Name = name;
            this.Basepay=bas;
            this.HRA = 0.15 * bas;
            this.DA = 0.10 * bas;
            this.GROSS = this.Basepay + this.DA + this.HRA;
            this.TAX = 0.08 * this.GROSS;
            this.NetPay = this.GROSS - this.TAX;   
        }
        public void displaySalary()
        {
            Console.WriteLine("NAME      {0}\nBASE PAY  {1}\nHRA       {2}\nDA        {3}\nGROSS PAY {4}\nTAX       {5}\nNET PAY   {6}",this.Name,this.Basepay,this.HRA,this.DA,this.GROSS,this.TAX,this.NetPay);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name and BasePay");
            empsalary emp1 = new empsalary();
            emp1.caldetails(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            emp1.displaySalary();
        }
    }
}
