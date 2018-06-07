using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConditionalMappingEntityFramework
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsTerminated { get; set; }
    }
}