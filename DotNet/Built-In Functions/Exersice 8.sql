select Extension as Salary , Title , HireDate  from Employees
where Title = 'Vice President, Sales' OR Title = 'Analyst'
AND YEAR(HireDate) > 1981
AND Extension > 2000
AND Extension > 5000
AND Extension > 7000