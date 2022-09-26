using System;
using System.Collections;

namespace Employee1
{
    class Employee1
    {
        public string EmployeeName { get; set; }
        public int EmpId { get; set; }
        public double Salary { get; set; }
    }

    class EmployeeDal : Employee1 {
        ArrayList arr = new ArrayList();
        public bool AddEmployee(Employee1 e) {
            bool sts = false;
            if (arr.Contains(e)) {
                sts = false;
            }
            else
            {
                arr.Add(e.EmployeeName);
                arr.Add(e.EmpId);
                arr.Add(e.Salary);
            }
            return sts;
            
        }
        public bool DeleteEmployee(int id) {
            bool sts = false;
            if (arr.Contains(id))
            {
                
                arr.Remove(id);
                sts = true;
            }
            else {
                sts = false;
            }

            return sts;

        }
        public string SearchEmployee(int id) {
            if (arr.Contains(id))
            {
                return "Employee id present";
            }
            else {
                return "Employee id not present";
            }
        }
        public Employee1[] GetAllEmployeesistAll() {
            Employee1[] h = new Employee1[arr.Count];
            foreach (var val in arr)
            {
                Console.WriteLine(val);
            }
            return h;  

        }

    }
    class Program {
        public static void Main(string [] args) {
            Employee1 e1 = new Employee1();
            EmployeeDal ed = new EmployeeDal();
            e1.EmployeeName = "Ramesh";
            e1.EmpId = 11;
            e1.Salary = 10000;
            Employee1 e2 = new Employee1();
            e2.EmployeeName = "Suresh";
            e2.EmpId = 13;
            e2.Salary = 110000;

            Employee1 e3 = new Employee1();
            e3.EmployeeName = "kamesh";
            e3.EmpId = 12;
            e3.Salary = 1210000;
            Console.WriteLine(ed.AddEmployee(e1));
            Console.WriteLine(ed.AddEmployee(e2));
            Console.WriteLine(ed.AddEmployee(e3));
            //Console.WriteLine(ed.DeleteEmployee(e1.EmpId));
            Console.WriteLine(ed.SearchEmployee(e1.EmpId));
            ed.GetAllEmployeesistAll();

        }
    }
}
