using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace FastFood.QL_NhanVien
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            HP_User_BUS log = new HP_User_BUS();
            string mess = log.Login_BUS(txtUsername.Text, txtPassword.Text);
            MessageBox.Show(mess);
        }
    }
}
