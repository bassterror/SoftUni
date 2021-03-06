-- Problem 23.	Write a SQL query to find all the employees and 
-- the manager for each of them along with the employees that do not have manager.
-- Use right outer join. Rewrite the query to use left outer join.

SELECT E.[FirstName]
      ,E.[LastName]
	  ,(M.FirstName + ' ' + M.LastName) as [Manager Name]
  FROM [SoftUni].[dbo].[Employees] as M
  RIGHT OUTER JOIN [SoftUni].[dbo].[Employees] as E on M.EmployeeID = E.ManagerID

SELECT E.[FirstName]
      ,E.[LastName]
	  ,(M.FirstName + ' ' + M.LastName) as [Manager Name]
  FROM [SoftUni].[dbo].[Employees] as E
  LEFT OUTER JOIN [SoftUni].[dbo].[Employees] as M on M.EmployeeID = E.ManagerID