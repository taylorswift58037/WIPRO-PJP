select LastName, LOWER(SUBSTRING(LastName,1,1))+UPPER(SUBSTRING(LastName,2,LEN(LastName)))
 as new from Employees