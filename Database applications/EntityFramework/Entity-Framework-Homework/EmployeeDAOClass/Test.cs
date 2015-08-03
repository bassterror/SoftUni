using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDAOClass
{
    class Test
    {
        static void Main(string[] args)
        {
            EmployeeDAOClass daoClass = new EmployeeDAOClass();
            using (SoftUniEntities entities = new SoftUniEntities())
            {
                Employees employee = new Employees()
                {
                    FirstName = "Zahari",
                    LastName = "Zahariev",
                    MiddleName = "Z",
                    JobTitle = "Production Technician",
                    DepartmentID = 7,
                    ManagerID = 16,
                    HireDate = DateTime.Now,
                    Salary = 125000.0M,
                    AddressID = 102
                };
                daoClass.Add(employee);
                Employees newEmployee = entities.Employees.FirstOrDefault(e => e.FirstName == "Zahari");
                Console.WriteLine(newEmployee.EmployeeID);
                
            }
        }
    }
}
