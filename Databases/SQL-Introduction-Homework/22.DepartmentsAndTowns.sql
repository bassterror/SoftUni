--Problem 22.	Write a SQL query to find all departments and all town names as a single list.
--Use UNION.

SELECT [Name]
FROM [SoftUni].[dbo].[Departments]
UNION
SELECT [Name]
FROM [SoftUni].[dbo].[Towns]