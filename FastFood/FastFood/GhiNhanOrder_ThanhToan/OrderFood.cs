using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;
//using System.Globalization;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace FastFood.GhiNhanOrder
{
    public partial class OrderFood : Form
    {
        //NChau
        #region Order 
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

            _Khoitao(); //KLinh
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
        #endregion

        //KLinh
        #region ThanhToan 
        private void _Khoitao()
        {
            try
            {
                lsbTenMA.Items.Clear();//Tự động xóa trắng 
                lsbThanhtien.Items.Clear();//Tự động xóa trắng
            }
            catch (Exception)
            {

            }
        }

        public static string _DoiSoSangDonViTienTe(object _object)
        {
            try
            {
                if (_object.ToString().Trim().Length == 0)
                { return " "; }

                if (_object.ToString() == "0")
                {
                    return "0,000";
                }
            }
            catch (Exception)
            {

            }
            return "0.000";
        }

        private void _TongTien()
        {
            try
            {
                if (lsbThanhtien.Items.Count == 0)
                    return;

                float ThanhTien = 0;
                float TongTien = 0;
                for (int i = 0; i < lsbThanhtien.Items.Count; i++)
                {
                    ThanhTien = Convert.ToSingle(lsbThanhtien.Items[i].ToString().Replace(",", ""));
                    TongTien = TongTien + ThanhTien;
                }
                nudTongtien.Value = Convert.ToDecimal(TongTien);
                
            }
            catch (Exception)
            {

            }
        }

        private void OrderFood_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
                case Keys.Enter:
                    {
                        btnThem_Click(null, null);
                        break;
                    }
            }
        }

        private void OrderFood_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void OrderFood_Shown(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Opacity = 100;
            }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                lsbThanhtien.Items.Add(lblTenmonan.Text);
                string Tam = _DoiSoSangDonViTienTe(nudDongia.Value.ToString());
                lsbThanhtien.Items.Add(Tam);
                _TongTien();
            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int Index = lsbTenMA.SelectedIndex;
                lsbTenMA.Items.RemoveAt(Index);
                lsbThanhtien.Items.RemoveAt(Index);
                _TongTien();
            }
            catch (Exception)
            {

            }
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                _PrintDialog.Document = _PrintDocument;

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt);
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("COPY TỚI...", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Tên Món Ăn".PadRight(24) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight;
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5;

            int index = 0;
            foreach (string item in lsbTenMA.Items)
            {
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(lsbThanhtien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5;
            }

            offset = offset + 20;

            graphic.DrawString("TỔNG TIỀN TRẢ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTongtien.Value), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5;
            graphic.DrawString("TIỀN MẶT",font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTienmat.Value),font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; 
            graphic.DrawString("TIỀN TRẢ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(_DoiSoSangDonViTienTe(nudTientra.Value), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5;
            graphic.DrawString("CÁM ƠN BẠN ĐÃ GHÉ THĂM!,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5;
            graphic.DrawString("HI VỌNG BẠN SẼ GHÉ THĂM LẠI!", font, new SolidBrush(Color.Black), startX, startY + offset); 
        }
        private void lsbTenMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbThanhtien.SelectedIndex = lsbTenMA.SelectedIndex;
        }

        private void lsbThanhtien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbTenMA.SelectedIndex = lsbThanhtien.SelectedIndex;
        }

        private void nudTienmat_ValueChanged(object sender, EventArgs e)
        {
            nudTientra.Value = nudTienmat.Value - nudTongtien.Value;
        }
        #endregion


    }
}
