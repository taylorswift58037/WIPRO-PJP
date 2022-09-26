SELECT LastName, FirstName
FROM Employees 
WHERE ReportsTo = (SELECT  EmployeeID FROM Employees
 WHERE LastName = 'KING' );