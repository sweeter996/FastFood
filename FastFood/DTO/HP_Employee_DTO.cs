using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HP_Employee_DTO
    {
        public int EmployeeID { get; set; }
        //public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Note { get; set; }
    }
}
