using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class HP_Employee_DAO
    {
        HP_SetConnect_DAO cn;
        public HP_Employee_DAO()
        {
            cn = new HP_SetConnect_DAO();
        }
        public DataTable SelectEmpl()
        {
            cn.Connect();
            //string query = "Select , EmployeeID From dbo.Employees";
            return cn.GetSelectDAO("EmployeeID AS N'Mã Nhân Viên', FirstName + ' ' + LastName AS N'Họ Tên'", "Employees");
        }
        public DataTable LookupEmpl(string lookupKey, int type)
        {
            switch (type)
            {
                case 1:
                    //int userID = 0;
                    if (cn.Lookup(lookupKey, "LastName", "Employees") != 0)
                    {
                        string query = "Select EmployeeID AS N'Mã Nhân Viên', FirstName + ' ' + LastName AS N'Họ Tên' From Employees Where LastName = @lastname";
                        SqlDataAdapter adpt = new SqlDataAdapter(query, cn.cn);
                        adpt.SelectCommand.Parameters.AddWithValue("@lastname", lookupKey);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                    break;
                case 2:
                    if (cn.Lookup(lookupKey, "EmployeeID", "Employees") != 0)
                    {
                        string query = "Select EmployeeID AS N'Mã Nhân Viên', FirstName + ' ' + LastName AS N'Họ Tên' From Employees Where EmployeeID = @id";
                        SqlDataAdapter adpt = new SqlDataAdapter(query, cn.cn);
                        adpt.SelectCommand.Parameters.AddWithValue("@id", lookupKey);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                    break;
            }
            return null;
        }

        public int AddEmpl(HP_Employee_DTO empl)
        {
            if (cn.Lookup(empl.EmployeeID.ToString(), "EmployeeID", "Employees") == 0)
            {
                cn.Connect();
                string query = "Insert into Employees Values (@EmployeeID, @FirstName, @LastName, @Phone, @Address, @Salary, @Note)";
                SqlCommand cmd = new SqlCommand(query, cn.cn);
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", empl.EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@FirstName", empl.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", empl.LastName));
                cmd.Parameters.Add(new SqlParameter("@Phone", empl.Phone));
                cmd.Parameters.Add(new SqlParameter("@Address", empl.Address));
                cmd.Parameters.Add(new SqlParameter("@Salary", empl.Salary));
                cmd.Parameters.Add(new SqlParameter("@Note", empl.Note));
                cmd.ExecuteNonQuery();
                cn.DisConnect();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int UpdateEmpl(HP_Employee_DTO empl)
        {
            cn.Connect();
            string query = "Update Employees Set FirstName = @firstname, LastName = @lastname, Phone =@phone, Address = @address, Salary = @salary, Note = @note " +
                "Where EmployeeID = @employeeID";
            SqlCommand cmd = new SqlCommand(query, cn.cn);
            cmd.Parameters.Add(new SqlParameter("@employeeID", empl.EmployeeID));
            cmd.Parameters.Add(new SqlParameter("@firstName", empl.FirstName));
            cmd.Parameters.Add(new SqlParameter("@lastName", empl.LastName));
            cmd.Parameters.Add(new SqlParameter("@phone", empl.Phone));
            cmd.Parameters.Add(new SqlParameter("@address", empl.Address));
            cmd.Parameters.Add(new SqlParameter("@salary", empl.Salary));
            cmd.Parameters.Add(new SqlParameter("@note", empl.Note));
            cmd.ExecuteNonQuery();
            return 1;
        }

        public HP_Employee_DTO ShowOnGrid(int EmpID)
        {
            cn.Connect();
            string query = "Select * From Employees Where EmployeeID = @emplID";
            SqlCommand cmd = new SqlCommand(query, cn.cn);
            cmd.Parameters.Add(new SqlParameter("@emplID", EmpID));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            HP_Employee_DTO employee = new HP_Employee_DTO();
            employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
            employee.FirstName = reader["FirstName"].ToString();
            employee.LastName = reader["LastName"].ToString();
            employee.Phone = reader["Phone"].ToString();
            employee.Address = reader["Address"].ToString();
            employee.Salary = Convert.ToDouble(reader["Salary"]);
            employee.Note = reader["Note"].ToString();
            cn.DisConnect();
            return employee;
        }

        public int DelEmpl(int Empl)
        {
            cn.Connect();
            string query1 = "Delete From Users Where EmployeeID = @emID";
            SqlCommand cmd1 = new SqlCommand(query1, cn.cn);
            cmd1.Parameters.Add(new SqlParameter("@emID", Empl));
            cmd1.ExecuteNonQuery();
            string query = "Delete From Employees Where EmployeeID = @emID";
            SqlCommand cmd = new SqlCommand(query, cn.cn);
            cmd.Parameters.Add(new SqlParameter("@emID", Empl));
            cmd.ExecuteNonQuery();
            cn.DisConnect();
            return 1;
        }

    }
}
