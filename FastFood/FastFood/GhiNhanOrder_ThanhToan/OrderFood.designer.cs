namespace FastFood.GhiNhanOrder
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbTenMA = new System.Windows.Forms.ListBox();
            this.lsbThanhtien = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTenmonan = new System.Windows.Forms.TextBox();
            this.nudDongia = new System.Windows.Forms.NumericUpDown();
            this.nudTientra = new System.Windows.Forms.NumericUpDown();
            this.nudTongtien = new System.Windows.Forms.NumericUpDown();
            this.nudTienmat = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDongia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTientra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongtien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienmat)).BeginInit();
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
            this.dgvMenu.Location = new System.Drawing.Point(15, 93);
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
            this.label1.Size = new System.Drawing.Size(935, 49);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Các món đã chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(770, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thành tiền:";
            // 
            // lsbTenMA
            // 
            this.lsbTenMA.FormattingEnabled = true;
            this.lsbTenMA.Location = new System.Drawing.Point(516, 93);
            this.lsbTenMA.Name = "lsbTenMA";
            this.lsbTenMA.Size = new System.Drawing.Size(232, 160);
            this.lsbTenMA.TabIndex = 8;
            this.lsbTenMA.SelectedIndexChanged += new System.EventHandler(this.lsbTenMA_SelectedIndexChanged);
            // 
            // lsbThanhtien
            // 
            this.lsbThanhtien.FormattingEnabled = true;
            this.lsbThanhtien.Location = new System.Drawing.Point(773, 93);
            this.lsbThanhtien.Name = "lsbThanhtien";
            this.lsbThanhtien.Size = new System.Drawing.Size(150, 160);
            this.lsbThanhtien.TabIndex = 9;
            this.lsbThanhtien.SelectedIndexChanged += new System.EventHandler(this.lsbThanhtien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiến hành thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiền mặt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiền trả:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tên món ăn:";
            // 
            // lblTenmonan
            // 
            this.lblTenmonan.AutoCompleteCustomSource.AddRange(new string[] {
            "Cơm chiên dương châu",
            "Cơm gà ",
            "Cơm sườn"});
            this.lblTenmonan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lblTenmonan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.lblTenmonan.Location = new System.Drawing.Point(97, 308);
            this.lblTenmonan.Name = "lblTenmonan";
            this.lblTenmonan.Size = new System.Drawing.Size(239, 20);
            this.lblTenmonan.TabIndex = 17;
            // 
            // nudDongia
            // 
            this.nudDongia.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDongia.Location = new System.Drawing.Point(97, 338);
            this.nudDongia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDongia.Name = "nudDongia";
            this.nudDongia.Size = new System.Drawing.Size(239, 20);
            this.nudDongia.TabIndex = 18;
            this.nudDongia.ThousandsSeparator = true;
            // 
            // nudTientra
            // 
            this.nudTientra.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTientra.Location = new System.Drawing.Point(97, 423);
            this.nudTientra.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTientra.Name = "nudTientra";
            this.nudTientra.Size = new System.Drawing.Size(239, 20);
            this.nudTientra.TabIndex = 19;
            this.nudTientra.ThousandsSeparator = true;
            // 
            // nudTongtien
            // 
            this.nudTongtien.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTongtien.Location = new System.Drawing.Point(97, 367);
            this.nudTongtien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTongtien.Name = "nudTongtien";
            this.nudTongtien.Size = new System.Drawing.Size(239, 20);
            this.nudTongtien.TabIndex = 20;
            this.nudTongtien.ThousandsSeparator = true;
            // 
            // nudTienmat
            // 
            this.nudTienmat.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTienmat.Location = new System.Drawing.Point(97, 397);
            this.nudTienmat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTienmat.Name = "nudTienmat";
            this.nudTienmat.Size = new System.Drawing.Size(239, 20);
            this.nudTienmat.TabIndex = 21;
            this.nudTienmat.ThousandsSeparator = true;
            this.nudTienmat.ValueChanged += new System.EventHandler(this.nudTienmat_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(456, 296);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 43);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(456, 353);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 44);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInhoadon.Location = new System.Drawing.Point(456, 407);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(108, 42);
            this.btnInhoadon.TabIndex = 24;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // OrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 461);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudTienmat);
            this.Controls.Add(this.nudTongtien);
            this.Controls.Add(this.nudTientra);
            this.Controls.Add(this.nudDongia);
            this.Controls.Add(this.lblTenmonan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbThanhtien);
            this.Controls.Add(this.lsbTenMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMenu);
            this.Name = "OrderFood";
            this.Text = "OrderFood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderFood_FormClosing);
            this.Load += new System.EventHandler(this.OrderFood_Load);
            this.Shown += new System.EventHandler(this.OrderFood_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderFood_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDongia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTientra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongtien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienmat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbTenMA;
        private System.Windows.Forms.ListBox lsbThanhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lblTenmonan;
        private System.Windows.Forms.NumericUpDown nudDongia;
        private System.Windows.Forms.NumericUpDown nudTientra;
        private System.Windows.Forms.NumericUpDown nudTongtien;
        private System.Windows.Forms.NumericUpDown nudTienmat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInhoadon;
    }
}