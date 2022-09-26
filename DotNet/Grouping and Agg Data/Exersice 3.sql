select Title ,SUM(Convert(int,Salary)) from Employees
group by Title