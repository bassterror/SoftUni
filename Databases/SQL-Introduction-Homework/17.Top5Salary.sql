-- Problem 17.	Write a SQL query to find the top 5 best paid employees.
SELECT top 5 [FirstName]
      ,[LastName]
	  ,[Salary]
  FROM [SoftUni].[dbo].[Employees]
  order by Salary desc