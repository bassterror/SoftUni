-- Problem 21.	Write a SQL query to find all employees, along with their manager and their address.
-- You should join the 3 tables: Employees e, Employees m and Addresses a.

SELECT E.[FirstName]
      ,E.[LastName]
	  ,(T.Name + ', ' + A.AddressText) as [Address]
	  ,(M.FirstName + ' ' + M.LastName) as [Manager Name]
  FROM [SoftUni].[dbo].[Employees] as E
  INNER JOIN [SoftUni].[dbo].[Employees] as M on M.EmployeeID = E.ManagerID
  INNER JOIN [SoftUni].[dbo].[Addresses] as A on A.AddressID = E.AddressID
  INNER JOIN [SoftUni].[dbo].[Towns] as T on T.TownID = A.TownID