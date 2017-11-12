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
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HP_Employee_DTO employ = new HP_Employee_DTO();
            employ.EmployeeID = Convert.ToInt32(txtMaNV.Text);
            //employ.UserID = Convert.ToInt32(txtIDDangNhap.Text);
            employ.FirstName = txtTenNV.Text;
            employ.LastName = txtHoNV.Text;
            employ.Phone = txtSDT.Text;
            employ.Address = txtDiaChi.Text;
            employ.Salary = Convert.ToDouble(txtLuong.Text);
            employ.Note = txtGhiChu.Text;
            if (txtMaNV.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên !");
            }
            else
            {
                HP_Employee_BUS em = new HP_Employee_BUS();
                int check = em.AddEmployee(employ);
                if(check == 1 )
                {
                    MessageBox.Show("Thêm Thành công !");
                    Close();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại ! Vui lòng nhập lại !");
                }
            }
        }
    }
}
