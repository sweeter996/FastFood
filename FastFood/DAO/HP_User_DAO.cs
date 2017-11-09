using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class HP_User_DAO
    {
        HP_SetConnect_DAO cn;
        public HP_User_DAO()
        {
            cn = new HP_SetConnect_DAO();
        }
        public string Login(string username, string password)
        {
            int userID = 0;
            if (cn.Lookup(username, "Username", "Users") != 0)
            {
                if (cn.Lookup(password, "Password", "Users") != 0)
                {
                    cn.Connect();
                    string query = "Select UserID From Users Where Username = '" + username + "'";
                    SqlCommand cmd = new SqlCommand(query, cn.cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userID = (int)reader["UserID"];
                    }
                    return (userID.ToString());
                }
                else
                {
                    return "Sai mật khẩu ! Vui lòng nhập lại ";
                }
            }
            else
            {
                return "Không tồn tại tên đăng nhập này ! Vui lòng nhập lại";
            }
        }
    }
}
