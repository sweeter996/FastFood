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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCheckedFood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckedFood)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(805, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi Nhận Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(579, 284);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(214, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label4.Location = new System.Drawing.Point(493, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thành tiền:";
            // 
            // OrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCheckedFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMenu);
            this.Name = "OrderFood";
            this.Text = "OrderFood";
            this.Load += new System.EventHandler(this.OrderFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckedFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
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
    }
}