using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class HP_User_BUS
    {
        public HP_User_DAO cn;
        public HP_User_BUS()
        {
            cn = new HP_User_DAO();
        }
        public string Login_BUS(string username, string password)
        {
            return cn.Login(username, password);
        }
    }
}
