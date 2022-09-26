SELECT * FROM Employees
where Extension > ALL(SELECT avg(Convert(int,Extension))FROM Employees GROUP BY Title);