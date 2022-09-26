using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.person("Muhilan", "S", "muhilan.48@gmail.com", Convert.ToDateTime("1999/03/7"));
            emp1.Salary = 20000;
            Console.WriteLine(emp1.isAdult);
            Console.WriteLine(emp1.sunsign);
            Console.WriteLine(emp1.isbirthday);
            Console.WriteLine(emp1.screenname);
        }
    }
}
