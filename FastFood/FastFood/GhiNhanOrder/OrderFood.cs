using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace FastFood.GhiNhanOrder
{
    public partial class OrderFood : Form
    {
        public OrderFood()
        {
            InitializeComponent();
        }

        public void OrderFood_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCategory.DataSource = new NC_OrderFood_BUS().GetCategory();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "FoodCategoryID";   
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int CategoryID = (int)cmbCategory.SelectedValue;
            dgvMenu.DataSource = new NC_OrderFood_BUS().GetData(CategoryID);
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgvMenu.Columns[col] is DataGridViewCheckBoxColumn && dgvMenu.Columns[col].Name == "Chon")
            {
                //List<int> listRowChecked = new List<int>();
                int row = e.RowIndex;
                int foodID = int.Parse(dgvMenu.Rows[row].Cells[1].Value.ToString());
                //listRowChecked.Add(foodID);
            }
        }
    }
}
