-- Problem 15.	Write a SQL query to find all employees that do not have manager.

SELECT [FirstName]
      ,[LastName]
  FROM [SoftUni].[dbo].[Employees]
  where ManagerID is null