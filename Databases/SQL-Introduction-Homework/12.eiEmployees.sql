-- Problem 12.	Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT [FirstName]
      ,[MiddleName]
      ,[LastName]
  FROM [SoftUni].[dbo].[Employees]
  where LastName like '%ei%'