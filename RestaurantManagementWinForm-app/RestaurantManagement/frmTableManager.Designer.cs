namespace RestaurantManagement
{
    partial class frmTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            nmDiscount = new NumericUpDown();
            btnSwitchTable = new Button();
            btnDiscount = new Button();
            cbSwitchTable = new ComboBox();
            btnCheckOut = new Button();
            panel4 = new Panel();
            btnAddFood = new Button();
            nmFoodCount = new NumericUpDown();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(949, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(122, 20);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(510, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 381);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.Enabled = false;
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(0, 0);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(427, 378);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 120;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(510, 496);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 69);
            panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalPrice.ForeColor = Color.IndianRed;
            txbTotalPrice.Location = new Point(215, 21);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(119, 25);
            txbTotalPrice.TabIndex = 3;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(108, 41);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(101, 23);
            nmDiscount.TabIndex = 2;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(3, -1);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(101, 36);
            btnSwitchTable.TabIndex = 1;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(108, -1);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(101, 36);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 41);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(101, 23);
            cbSwitchTable.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(340, 0);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(87, 66);
            btnCheckOut.TabIndex = 1;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(510, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(427, 63);
            panel4.TabIndex = 4;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(215, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(101, 60);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(322, 17);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(93, 23);
            nmFoodCount.TabIndex = 2;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(0, 29);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(209, 23);
            cbFood.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(0, 0);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(209, 23);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 43);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(492, 522);
            flpTable.TabIndex = 5;
            // 
            // frmTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 604);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lí nhà hàng";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private NumericUpDown nmFoodCount;
        private FlowLayoutPanel flpTable;
        private Button btnCheckOut;
        private NumericUpDown nmDiscount;
        private Button btnSwitchTable;
        private Button btnDiscount;
        private ComboBox cbSwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        public ListView lsvBill;
        private TextBox txbTotalPrice;
    }
}