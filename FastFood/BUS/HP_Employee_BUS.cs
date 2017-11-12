using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class HP_Employee_BUS
    {
        HP_Employee_DAO empl;
        public HP_Employee_BUS()
        {
            empl = new HP_Employee_DAO();
        }
        public DataTable SelectEmployee()
        {
            return empl.SelectEmpl();
        }
        public DataTable LookupEmployee(string key, int type)
        {
            return empl.LookupEmpl(key, type);
        }
        public int AddEmployee(HP_Employee_DTO emp)
        {
            return empl.AddEmpl(emp);
        }
        public int UpdateEmployee(HP_Employee_DTO emp)
        {
            empl.UpdateEmpl(emp);
            return 1;
        }
        public HP_Employee_DTO ShowOnGirdView(int empID)
        {
            return empl.ShowOnGrid(empID);
        }
        public int DelEmployee(int EmployeeID)
        {
            return empl.DelEmpl(EmployeeID);
        }
    }
}
