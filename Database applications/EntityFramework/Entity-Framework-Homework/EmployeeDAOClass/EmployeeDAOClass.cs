using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDAOClass
{
    public class EmployeeDAOClass
    {
        public void Add(Employees employee)
        {
            using (SoftUniEntities entities = new SoftUniEntities())
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();
            }
        }

        public Employees FindByKey(object key)
        {
            using (SoftUniEntities entities = new SoftUniEntities())
            {
                Employees employee = entities.Employees.Find(key);
                return employee;
            }
        }
    }
}
