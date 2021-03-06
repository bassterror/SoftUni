-- Problem 20.	Write a SQL query to find all employees along with their manager.

SELECT E.[FirstName]
      ,E.[LastName]
	  ,(M.FirstName + ' ' + M.LastName) as [Manager Name]
  FROM [SoftUni].[dbo].[Employees] as E
  INNER JOIN [SoftUni].[dbo].[Employees] as M on M.EmployeeID = E.ManagerID
UNION SELECT E.[FirstName]
      ,E.[LastName]
	  ,'No manager' as [Manager Name]
  FROM [SoftUni].[dbo].[Employees] as E
  WHERE E.ManagerID is null