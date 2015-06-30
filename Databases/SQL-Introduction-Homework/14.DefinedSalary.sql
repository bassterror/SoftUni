-- Problem 14.	Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT [FirstName]
      ,[LastName]
	  ,[Salary]
  FROM [SoftUni].[dbo].[Employees]
  where Salary in (25000, 14000, 12500, 23600)