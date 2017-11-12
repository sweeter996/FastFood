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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new HP_Employee_BUS().SelectEmployee();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new HP_Employee_BUS().SelectEmployee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdTen.Checked)
            {
                if (txtTenLookup.Text != "")
                {
                    dataGridView1.DataSource = new HP_Employee_BUS().LookupEmployee(txtTenLookup.Text, 1);
                }
                else
                {
                    MessageBox.Show("Nhập Tên Tìm Kiếm !");
                }
            }
            if (rdMaNV.Checked)
            {
                if (txtMaLookup.Text != "")
                {
                    dataGridView1.DataSource = new HP_Employee_BUS().LookupEmployee(txtMaLookup.Text, 2);
                }
                else
                {
                    MessageBox.Show("Nhập mã tìm kiếm !");
                }
            }
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTenLookup.Text = "";
            txtTenLookup.ReadOnly = false;
            txtMaLookup.ReadOnly = true;
        }

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaLookup.Text = "";
            txtMaLookup.ReadOnly = false;
            txtTenLookup.ReadOnly = true;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Form f = new ThemNV();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtHo.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLuong.ReadOnly = false;
            txtLuong.ReadOnly = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int emID = dataGridView1.CurrentCell.RowIndex+1;
            HP_Employee_BUS Embus = new HP_Employee_BUS();
            HP_Employee_DTO emp = new HP_Employee_BUS().ShowOnGirdView(emID);
            txtMaNV.Text = emp.EmployeeID.ToString();
            txtHo.Text = emp.LastName.ToString();
            txtTen.Text = emp.FirstName.ToString();
            txtSDT.Text = emp.Phone.ToString();
            txtDiaChi.Text = emp.Address.ToString();
            txtLuong.Text = emp.Salary.ToString();
            txtGhiChu.Text = emp.Note.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn lưu","Chú ý",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                HP_Employee_DTO emp = new HP_Employee_DTO();
                emp.EmployeeID = Convert.ToInt32(txtMaNV.Text);
                emp.LastName = txtHo.Text;
                emp.FirstName = txtTen.Text;
                emp.Phone = txtSDT.Text;
                emp.Address = txtDiaChi.Text;
                emp.Salary = Convert.ToDouble(txtLuong.Text);
                emp.Note = txtGhiChu.Text;
                HP_Employee_BUS embus = new HP_Employee_BUS();
                int result = embus.UpdateEmployee(emp);
                if(result ==1)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            else
            {
                txtHo.ReadOnly = true;
                txtTen.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtLuong.ReadOnly = true;
                txtLuong.ReadOnly = true;
                int emID = dataGridView1.CurrentCell.RowIndex + 1;
                HP_Employee_BUS Embus = new HP_Employee_BUS();
                HP_Employee_DTO emp = new HP_Employee_BUS().ShowOnGirdView(emID);
                txtMaNV.Text = emp.EmployeeID.ToString();
                txtHo.Text = emp.LastName.ToString();
                txtTen.Text = emp.FirstName.ToString();
                txtSDT.Text = emp.Phone.ToString();
                txtDiaChi.Text = emp.Address.ToString();
                txtLuong.Text = emp.Salary.ToString();
                txtGhiChu.Text = emp.Note.ToString();
            }
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            HP_Employee_BUS embus;
            if(MessageBox.Show("Bạn có chắc muốn xóa nhân viên này !","Chú ý !",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                embus = new HP_Employee_BUS();
                int result = embus.DelEmployee(Convert.ToInt32(txtMaNV.Text));
                if(result==1)
                {
                    MessageBox.Show("Xóa thành công !");
                    dataGridView1.DataSource = embus.SelectEmployee();
                    txtMaNV.Text = "";
                    txtHo.Text = "";
                    txtTen.Text = "";
                    txtSDT.Text = "";
                    txtDiaChi.Text = "";
                    txtLuong.Text = "";
                    txtGhiChu.Text = "";
                }
            }
        }
    }
}
