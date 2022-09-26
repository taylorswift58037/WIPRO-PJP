using System;

namespace Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Select the option\n                   1. Interest Calculator - SB\n                   2. Interest Calculator - FD\n                   3. Interest Calculator - RD\n                   4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    //SBACCOUNT
                    case 1:
                        {
                            here1:
                            Console.WriteLine("Enter the Average amount in yout account");
                            SBAccount sb = new SBAccount();
                            try
                            {
                                double Amount = Convert.ToInt32(Console.ReadLine());
                                checknegative(Amount);
                                sb.Amount = Amount;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                Console.WriteLine();
                                goto here1;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine();
                                goto here1;
                            }
                            here2:
                            Console.WriteLine("Select the optionSelect the option\n                   1. Normal\n                   2. NRI");
                            int ch1=Convert.ToInt32(Console.ReadLine());
                            if(ch1==1)
                            {
                                sb.Interest_rate = 0.04;
                            }
                            else if(ch1==2)
                            {
                                sb.Interest_rate = 0.06;
                            }
                            else
                            {
                                Console.WriteLine("Choose 1 or 2 only");
                                Console.WriteLine();
                                goto here2;
                            }

                            sb.Calculate_Interest();
                          
                            break;
                           
                        }
                    //FDACCOUNT    
                    case 2:
                        {
                            FDAccount fd = new FDAccount();
                           
                            here3:
                            Console.WriteLine("Enter the FD amount:");
                            try
                            {
                                double Amount = Convert.ToInt32(Console.ReadLine());
                                checknegative(Amount);
                                fd.Amount = Amount;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                goto here3;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto here3;
                            }
                            here4:
                            Console.WriteLine("Enter the number of days:");
                            try
                            {
                                int days = Convert.ToInt32(Console.ReadLine());
                                checknegative(days);
                                fd.No_of_days = days;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                goto here4;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto here4;
                            }
                        here5:
                            Console.WriteLine("Enter your age:");
                            try
                            {
                                int age = Convert.ToInt32(Console.ReadLine());
                                checknegative(age);
                                fd.Age = age;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                goto here5;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto here5;
                            }
                            fd.Calculate_Interest();

                            break;
                        }
                    case 3:
                        {
                            RDAccount rd = new RDAccount();
                            
                        here3:
                            Console.WriteLine("Enter the RD amount:");
                            try
                            {
                                double Amount = Convert.ToInt32(Console.ReadLine());
                                checknegative(Amount);
                                rd.Amount = Amount;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                goto here3;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto here3;
                            }
                        here4:
                            Console.WriteLine("Enter the number of Months:");
                            try
                            {
                                int months = Convert.ToInt32(Console.ReadLine());
                                checknegative(months);
                                rd.No_of_Months = months;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                goto here4;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto here4;
                            }
                        here5:
                            Console.WriteLine("Enter your age:");
                            try
                            {
                                int age = Convert.ToInt32(Console.ReadLine());
                                checknegative(age);
                                rd.Age = age;
                            }
                            catch (NegativeException ex)
                            {
                                Console.WriteLine(ex);
                                goto here5;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                goto here5;
                            }
                            rd.Calculate_Interest();

                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Choose only from the options");
                            Console.WriteLine();
                            break;
                        }
                }
            }
        }
        public static void checknegative(double number)
        {
            if(number<=0)
            {
                throw new NegativeException("Number invalid (0 or Negative Entered)");
            }
        }
    }
    interface Account
    {
        public double Interest_rate { get; set; }
        public double Amount { get; set; }
        public void Calculate_Interest();
        
    }
    class FDAccount: Account
    {
        public double Interest_rate { get; set; }
        public double Amount { get; set; }
        public int No_of_days { get; set; }
        public int Age { get; set; }

        public void Calculate_Interest()
        {
            double interest = 0;
            if (Amount >= 1000000)
            {
                if(No_of_days >=7 && No_of_days<=14)
                {
                    Interest_rate = 6.50;
                }
                else if(No_of_days >= 15 && No_of_days <= 29)
                {
                    Interest_rate = 6.75;
                }
                else if(No_of_days >= 30 && No_of_days <= 45)
                {
                    Interest_rate = 6.75;
                }
                else if(No_of_days >= 46 && No_of_days <= 60)
                {
                    Interest_rate = 8;
                }
                else if(No_of_days >= 61 && No_of_days <= 184)
                {
                    Interest_rate = 8.50;
                }
                else if (No_of_days >= 185 && No_of_days <= 365)
                {
                    Interest_rate = 10;
                }
                else
                {
                    Console.WriteLine("Invalid Days Enter Between 7 to 365 days");
                    return;
                }
            }
            else
            {
                if (No_of_days >= 7 && No_of_days <= 14)
                {
                    Interest_rate = 4.50;
                }
                else if (No_of_days >= 15 && No_of_days <= 29)
                {
                    Interest_rate = 4.75;
                }
                else if (No_of_days >= 30 && No_of_days <= 45)
                {
                    Interest_rate = 5.50;
                }
                else if (No_of_days >= 46 && No_of_days <= 60)
                {
                    Interest_rate = 7;
                }
                else if (No_of_days >= 61 && No_of_days <= 184)
                {
                    Interest_rate = 7.50;
                }
                else if (No_of_days >= 185 && No_of_days <= 365)
                {
                    Interest_rate = 8;
                }
                else
                {
                    Console.WriteLine("Invalid Days Enter Between 7 to 365 days");
                    return;
                }
            }
            if(Age>=60)
            {
                Interest_rate += 0.50;
            }
            interest = Amount * Interest_rate;
            Console.WriteLine();
            Console.WriteLine("FD Interest:" + interest);
        }

    }
    class SBAccount: Account
    {
        public double Interest_rate { get; set; }
        public double Amount { get; set; }
        public void Calculate_Interest()
        {
            double interest = 0;
            interest = Amount * Interest_rate;
            Console.WriteLine();
            Console.WriteLine("SD Interest:" + interest);

        }
    }
    class RDAccount:Account
    {
        public double Interest_rate { get; set; }
        public double Amount { get; set; }
        public int No_of_Months { get; set; }
        public int Age { get; set; }
        public void Calculate_Interest()
        {
            double interest = 0;
            if (No_of_Months == 6)
            {
                Interest_rate = 7.50;
            }
            else if(No_of_Months==9)
            {
                Interest_rate = 7.75;
            }
            else if (No_of_Months == 12)
            {
                Interest_rate = 8;
            }
            else if (No_of_Months == 15)
            {
                Interest_rate = 8.25;
            }
            else if (No_of_Months == 18)
            {
                Interest_rate = 8.50;
            }
            else if (No_of_Months == 21)
            {
                Interest_rate = 8.75;
            }
            else
            {
                Console.WriteLine("Invalid Months Enter Between 6 to 21");
                return;
            }
            if(Age>=60)
            {
                Interest_rate += 0.50;
            }
            interest = Amount * Interest_rate;
            Console.WriteLine();
            Console.WriteLine("RD Interest:"+interest);
        }
    }
    class NegativeException : Exception
    {
        public NegativeException(string message) : base(message)
        {

        }
    }
    
}
