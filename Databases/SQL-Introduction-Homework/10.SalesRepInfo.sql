-- Problem 10.	Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

SELECT *
  FROM [SoftUni].[dbo].[Employees]
  WHERE JobTitle like '%Sales Representative%'