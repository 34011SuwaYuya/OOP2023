using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise01 {
    
    [XmlRoot ( "emps" )]
    public class EmployeeCollection {
        [XmlElement ( Type = typeof ( Employee ), ElementName = "employee" )]
        public Employee[] employeeList { get; set; }
    }
}
