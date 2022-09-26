using System;
using System.IO;
using System.Text.RegularExpressions;

namespace formatException
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] name = new string[3];
            int[] mark = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter 1.Student Name \n      2.Mark ");
                name[i] = Console.ReadLine();
                try
                {
                    mark[i] = Convert.ToInt32(Console.ReadLine());
                    check(mark[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a number", mark[i]);
                    // Console.WriteLine(ex.Message);
                }
                catch (NegativeNumberException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Person emp1 = new Person();

                    emp1.person("Muhilan", "S", "muhilan.48@gmail.com", Convert.ToDateTime("1999/03/7"));
                }

                
            }
        }
        public static void check(int num)
        {
            if(num<0)
            {
                throw new NegativeNumberException("Negative not allowed");
            }
        }
            
    }
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(): base()
        {

        }
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
    class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private DateTime DateofBirth;

        public void person(string fname, string lname, string email, DateTime dob)
        {
            try
            {
                check(fname);
                this.FirstName = fname;
                
            }
            catch (validateexeption ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                check(lname);
                this.LastName = lname;
            }
            catch (validateexeption ex)
            {
                Console.WriteLine(ex);
            }
            this.EmailAddress = email;
            this.DateofBirth = dob;
        }
        public static void check(string name)
        {
            if(!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            throw new validateexeption("Only Alphabets allowed");
        }   
    }
    class validateexeption : Exception
    {
        public validateexeption(): base()
        {


        }
        public validateexeption(string message) : base(message)
        {

        }
    }
}
