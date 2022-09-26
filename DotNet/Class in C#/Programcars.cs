using System;

namespace CAR
{
   class Customers
    {
        String fname;
        String lname;
        int age;

        public Customers(String first, String Last, int Age)
        {
            this.fname = first;
            this.lname = Last;
            this.age = Age;
        }

        public void printcustomersdetails()
        {
            Console.WriteLine("Name = " + fname + " " + lname + "\nAge = " + age);
        }
    }
    class Programcars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer details");
            String nam1 = Console.ReadLine();
            String nam2 = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Customers c1 = new Customers(nam1, nam2, age);
            

            Console.WriteLine("Enter Car details Company Model Year City");
            String carname1 = Console.ReadLine();
            String model = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine());
            String city = Console.ReadLine();
            Cars car1 = new Cars(carname1, model, year, city);
            c1.printcustomersdetails();
            car1.printcarsdetails();
            Console.ReadKey();
        }
    }
    class Cars
    {
        string carname1, model, city;
        int year;
        public Cars(String Cname, String Cmodel, int Cyear,String Ccity)
        {
            this.carname1 = Cname;
            this.city = Ccity;
            this.model = Cmodel;
            this.year = Cyear;
        }
        public void printcarsdetails()
        {
            Console.WriteLine("Car Company = " + this.carname1 + "\nCar model = " + this.model + "\nYead = " + this.year + "\nCity = "+ this.city);
        }
    }
}
