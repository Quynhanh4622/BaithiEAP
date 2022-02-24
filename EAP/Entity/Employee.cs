using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EAP.Entity
{
        [DataContract]
        public class Employee
        {
            [Key]
            [DataMember]
            public int EmployeeId { get; set; }
            [DataMember]
            public string EmployeeName { get; set; }
            [DataMember]
            public string EmployeeSalary { get; set; }
            [DataMember]
            public string Department { get; set; }

        }
    }