-- Problem 18.	Write a SQL query to find all employees along with their address.
-- Use inner join with ON clause.

SELECT E.[EmployeeID]
      ,E.[FirstName]
      ,E.[LastName]
	  ,(T.[Name] + ', ' + A.[AddressText]) as [Address]
  FROM [SoftUni].[dbo].[Employees] as E
  inner join SoftUni.dbo.Addresses as A on A.AddressID = E.AddressID
  inner join [SoftUni].[dbo].[Towns] as T on T.TownID = A.TownID