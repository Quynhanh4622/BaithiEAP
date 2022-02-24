using EAP.Data;
using EAP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MyDBContext db = new MyDBContext();
        public Employee CreateEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }
        public List<Employee> ListEmployee(string department)
        {
            var employees = from s in db.Employees
                           select s;
            if (!String.IsNullOrEmpty(department))
            {
                employees = employees.Where(s => s.Department.Contains(department));
            }
            return employees.ToList();
        }
    }
}
