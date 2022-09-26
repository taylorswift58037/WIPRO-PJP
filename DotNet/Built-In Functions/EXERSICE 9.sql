select *  from employee
 where CONVERT(varchar,hire_date) LIKE '%28%'
 OR  CONVERT(varchar,hire_date) LIKE '%29%'
 OR CONVERT(varchar,hire_date) LIKE '%30%'
