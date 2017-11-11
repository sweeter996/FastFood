﻿namespace FastFood.GhiNhanOrder
{
    partial class OrderFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCheckedFood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nbTongtien = new System.Windows.Forms.NumericUpDown();
            this.nbDongia = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nbTienmat = new System.Windows.Forms.NumericUpDown();
            this.nbTientra = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.lsbThanhtien = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckedFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTongtien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDongia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTienmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTientra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Chon,
            this.Column5});
            this.dgvMenu.Location = new System.Drawing.Point(12, 111);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(478, 161);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FoodID";
            this.Column1.HeaderText = "Mã món";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodName";
            this.Column2.HeaderText = "Tên món";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FoodCgrID";
            this.Column6.HeaderText = "Mã loại";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Note";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1028, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi Nhận Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(113, 66);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn loại món ăn: ";
            // 
            // dgvCheckedFood
            // 
            this.dgvCheckedFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckedFood.Location = new System.Drawing.Point(496, 111);
            this.dgvCheckedFood.Name = "dgvCheckedFood";
            this.dgvCheckedFood.Size = new System.Drawing.Size(297, 161);
            this.dgvCheckedFood.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Các món đã chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(900, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng tiền:";
            // 
            // nbTongtien
            // 
            this.nbTongtien.Location = new System.Drawing.Point(177, 347);
            this.nbTongtien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbTongtien.Name = "nbTongtien";
            this.nbTongtien.Size = new System.Drawing.Size(214, 20);
            this.nbTongtien.TabIndex = 10;
            this.nbTongtien.ThousandsSeparator = true;
            // 
            // nbDongia
            // 
            this.nbDongia.Location = new System.Drawing.Point(177, 322);
            this.nbDongia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbDongia.Name = "nbDongia";
            this.nbDongia.Size = new System.Drawing.Size(214, 20);
            this.nbDongia.TabIndex = 11;
            this.nbDongia.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền mặt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiền trả:";
            // 
            // nbTienmat
            // 
            this.nbTienmat.Location = new System.Drawing.Point(177, 373);
            this.nbTienmat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbTienmat.Name = "nbTienmat";
            this.nbTienmat.Size = new System.Drawing.Size(214, 20);
            this.nbTienmat.TabIndex = 14;
            this.nbTienmat.ThousandsSeparator = true;
            this.nbTienmat.ValueChanged += new System.EventHandler(this.nbTienmat_ValueChanged);
            // 
            // nbTientra
            // 
            this.nbTientra.Location = new System.Drawing.Point(177, 399);
            this.nbTientra.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbTientra.Name = "nbTientra";
            this.nbTientra.Size = new System.Drawing.Size(214, 20);
            this.nbTientra.TabIndex = 15;
            this.nbTientra.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tiến hành thanh toán";
            // 
            // btninhoadon
            // 
            this.btninhoadon.Location = new System.Drawing.Point(572, 373);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(86, 41);
            this.btninhoadon.TabIndex = 17;
            this.btninhoadon.Text = "In hóa đơn";
            this.btninhoadon.UseVisualStyleBackColor = true;
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // lsbThanhtien
            // 
            this.lsbThanhtien.FormattingEnabled = true;
            this.lsbThanhtien.Location = new System.Drawing.Point(814, 111);
            this.lsbThanhtien.Name = "lsbThanhtien";
            this.lsbThanhtien.Size = new System.Drawing.Size(202, 160);
            this.lsbThanhtien.TabIndex = 18;
            // 
            // OrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 426);
            this.Controls.Add(this.lsbThanhtien);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nbTientra);
            this.Controls.Add(this.nbTienmat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nbDongia);
            this.Controls.Add(this.nbTongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCheckedFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMenu);
            this.Name = "OrderFood";
            this.Text = "OrderFood";
            this.Load += new System.EventHandler(this.OrderFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckedFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTongtien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDongia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTienmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTientra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCheckedFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbTongtien;
        private System.Windows.Forms.NumericUpDown nbDongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nbTienmat;
        private System.Windows.Forms.NumericUpDown nbTientra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.ListBox lsbThanhtien;
    }
}