-- Problem 7.	Write a SQL to find the full name of each employee. 

SELECT ([FirstName] + ' ' + ISNULL([MiddleName] + ' ', '') + [LastName]) as FullName
  FROM [SoftUni].[dbo].[Employees]