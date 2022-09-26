SELECT * FROM employees 
WHERE Convert(int,Salary) > ALL(SELECT avg(Convert(int,Salary))FROM employees GROUP BY Title);