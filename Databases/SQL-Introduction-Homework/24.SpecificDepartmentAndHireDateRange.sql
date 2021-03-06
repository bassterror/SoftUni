--Problem 24.	Write a SQL query to find the names of all employees from
--the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT E.[FirstName]
      ,E.[LastName]
	  ,D.Name as [Department]
	  ,E.HireDate
  FROM [SoftUni].[dbo].[Employees] as E
  left join [SoftUni].[dbo].[Departments] as D on D.DepartmentID = E.DepartmentID
  where (E.DepartmentID = 3 or E.DepartmentID = 10)
  and (YEAR(E.HireDate) between 1995 and 2005)