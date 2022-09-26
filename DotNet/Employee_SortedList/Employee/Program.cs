using System;
using System.Collections.Generic;
using System.Collections;

public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public double salary { get; set; }

}
class EmployeeDAL
{
    public int j = 1;
    SortedList emp = new SortedList();
    public bool AddEmployee(Employee e)
    {
        bool sts = false;
        if (e != null)
        {
            emp.Add(e.EmployeeID, e);
            sts = true;
        }
        j++;
        return sts;
    }
    public bool DeleteEmployee(int id)
    {
        bool sts = false;
        int d;
        for (int i = 0; i < emp.Count; i++)
        {
            d = (int)emp.GetKey(i);
            if (id == d)
            {
                emp.Remove(i);
                sts = true;
            }
        }
        return sts;
    }
    public string SearchEmployee(int id)
    {
        ICollection key = emp.Keys;

        foreach (Employee o in key)
        {
            return o.EmployeeName;
            
        }
        return "n";
    }

    public Employee[] GetAllEmployeesistAll()
    {
        Employee[] emarr = new Employee[emp.Count];
        int i = 0;
        foreach (Employee e in emp)
        {
            emarr[i] = e;
            i++;
        }
        return emarr;
    }
}
class MainUser
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.EmployeeID = 1000;
        e1.EmployeeName = "abc";
        e1.salary = 120000;
        Employee e2 = new Employee();
        e2.EmployeeID = 2000;
        e2.EmployeeName = "cde";
        e2.salary = 100000;
        Employee e3 = new Employee();
        e3.EmployeeID = 3000;
        e3.EmployeeName = "fed";
        e3.salary = 12000;
        EmployeeDAL e = new EmployeeDAL();
        Console.WriteLine(e.AddEmployee(e1));
        Console.WriteLine(e.AddEmployee(e2));
        Console.WriteLine(e.DeleteEmployee(1000));
        Console.WriteLine(e.SearchEmployee(2000));



        Console.Read();
    }
}