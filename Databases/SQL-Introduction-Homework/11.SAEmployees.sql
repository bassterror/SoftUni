-- Problem 11.	Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT [FirstName]
      ,[MiddleName]
      ,[LastName]
  FROM [SoftUni].[dbo].[Employees]
  where FirstName like 'SA%'