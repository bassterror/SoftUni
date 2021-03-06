-- Problem 19.	Write a SQL query to find all employees and their address.
--Use equijoins (conditions in the WHERE clause).

SELECT E.[EmployeeID]
      ,E.[FirstName]
      ,E.[LastName]
	  ,(T.[Name] + ', ' + A.[AddressText]) as [Address]
  FROM [SoftUni].[dbo].[Employees] as E, SoftUni.dbo.Addresses as A, [SoftUni].[dbo].[Towns] as T
  where A.AddressID = E.AddressID
  and T.TownID = A.TownID