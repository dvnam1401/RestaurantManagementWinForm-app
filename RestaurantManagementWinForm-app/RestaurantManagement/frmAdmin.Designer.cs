namespace RestaurantManagement
{
    partial class frmAdmin
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
            tpAccount = new TabPage();
            panel1 = new Panel();
            btnResetPassword = new Button();
            panel17 = new Panel();
            nmAccountType = new NumericUpDown();
            label6 = new Label();
            panel20 = new Panel();
            txbDisplayName = new TextBox();
            label12 = new Label();
            panel26 = new Panel();
            txbUserName = new TextBox();
            label13 = new Label();
            panel28 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            dtgvAccount = new DataGridView();
            tpTable = new TabPage();
            panel24 = new Panel();
            cbTableStatus = new ComboBox();
            label11 = new Label();
            panel16 = new Panel();
            panel22 = new Panel();
            textBox1 = new TextBox();
            label9 = new Label();
            panel23 = new Panel();
            textBox2 = new TextBox();
            label10 = new Label();
            panel25 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            dtgvTable = new DataGridView();
            tpFoodCategory = new TabPage();
            panel15 = new Panel();
            panel18 = new Panel();
            txbCategoryName = new TextBox();
            label7 = new Label();
            panel19 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel21 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            dtgvCategory = new DataGridView();
            tpFood = new TabPage();
            panel10 = new Panel();
            panel14 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel13 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel12 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel11 = new Panel();
            txbFoodID = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel5 = new Panel();
            dtgvFood = new DataGridView();
            panel8 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            tpBill = new TabPage();
            panel3 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            dtgvBill = new DataGridView();
            tcAdmin = new TabControl();
            tpAccount.SuspendLayout();
            panel1.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).BeginInit();
            panel20.SuspendLayout();
            panel26.SuspendLayout();
            panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            tpTable.SuspendLayout();
            panel24.SuspendLayout();
            panel16.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel15.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            tpFood.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel8.SuspendLayout();
            tpBill.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tcAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel1);
            tpAccount.Controls.Add(panel28);
            tpAccount.Controls.Add(dtgvAccount);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(743, 450);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnResetPassword);
            panel1.Controls.Add(panel17);
            panel1.Controls.Add(panel20);
            panel1.Controls.Add(panel26);
            panel1.Location = new Point(405, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 379);
            panel1.TabIndex = 9;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(188, 192);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(122, 49);
            btnResetPassword.TabIndex = 0;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(nmAccountType);
            panel17.Controls.Add(label6);
            panel17.Location = new Point(0, 128);
            panel17.Name = "panel17";
            panel17.Size = new Size(310, 58);
            panel17.TabIndex = 3;
            // 
            // nmAccountType
            // 
            nmAccountType.Location = new Point(121, 17);
            nmAccountType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmAccountType.Name = "nmAccountType";
            nmAccountType.Size = new Size(85, 23);
            nmAccountType.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 17);
            label6.Name = "label6";
            label6.Size = new Size(123, 27);
            label6.TabIndex = 0;
            label6.Text = "Loại tài khoản:";
            // 
            // panel20
            // 
            panel20.Controls.Add(txbDisplayName);
            panel20.Controls.Add(label12);
            panel20.Location = new Point(0, 64);
            panel20.Name = "panel20";
            panel20.Size = new Size(310, 58);
            panel20.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(121, 17);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(183, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 17);
            label12.Name = "label12";
            label12.Size = new Size(106, 27);
            label12.TabIndex = 0;
            label12.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbUserName);
            panel26.Controls.Add(label13);
            panel26.Location = new Point(0, 0);
            panel26.Name = "panel26";
            panel26.Size = new Size(310, 58);
            panel26.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(121, 17);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(183, 23);
            txbUserName.TabIndex = 1;
            txbUserName.Text = " ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 17);
            label13.Name = "label13";
            label13.Size = new Size(121, 27);
            label13.TabIndex = 0;
            label13.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            panel28.Controls.Add(btnShowAccount);
            panel28.Controls.Add(btnEditAccount);
            panel28.Controls.Add(btnDeleteAccount);
            panel28.Controls.Add(btnAddAccount);
            panel28.Location = new Point(6, 6);
            panel28.Name = "panel28";
            panel28.Size = new Size(393, 49);
            panel28.TabIndex = 7;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(308, 0);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(85, 49);
            btnShowAccount.TabIndex = 0;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(204, 0);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(85, 49);
            btnEditAccount.TabIndex = 0;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(103, 0);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(85, 49);
            btnDeleteAccount.TabIndex = 0;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(0, 0);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(85, 49);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(6, 59);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.Size = new Size(393, 381);
            dtgvAccount.TabIndex = 10;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel24);
            tpTable.Controls.Add(panel16);
            tpTable.Controls.Add(panel25);
            tpTable.Controls.Add(dtgvTable);
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(743, 450);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(cbTableStatus);
            panel24.Controls.Add(label11);
            panel24.Location = new Point(426, 195);
            panel24.Name = "panel24";
            panel24.Size = new Size(310, 58);
            panel24.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(98, 19);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(204, 23);
            cbTableStatus.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 17);
            label11.Name = "label11";
            label11.Size = new Size(95, 27);
            label11.TabIndex = 0;
            label11.Text = "Trạng thái:";
            // 
            // panel16
            // 
            panel16.Controls.Add(panel22);
            panel16.Controls.Add(panel23);
            panel16.Location = new Point(427, 67);
            panel16.Name = "panel16";
            panel16.Size = new Size(312, 379);
            panel16.TabIndex = 9;
            // 
            // panel22
            // 
            panel22.Controls.Add(textBox1);
            panel22.Controls.Add(label9);
            panel22.Location = new Point(0, 64);
            panel22.Name = "panel22";
            panel22.Size = new Size(310, 58);
            panel22.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 17);
            label9.Name = "label9";
            label9.Size = new Size(80, 27);
            label9.TabIndex = 0;
            label9.Text = "Tên bàn:";
            // 
            // panel23
            // 
            panel23.Controls.Add(textBox2);
            panel23.Controls.Add(label10);
            panel23.Location = new Point(0, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(310, 58);
            panel23.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 17);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 17);
            label10.Name = "label10";
            label10.Size = new Size(32, 27);
            label10.TabIndex = 0;
            label10.Text = "ID:";
            // 
            // panel25
            // 
            panel25.Controls.Add(btnShowTable);
            panel25.Controls.Add(btnEditTable);
            panel25.Controls.Add(btnDeleteTable);
            panel25.Controls.Add(btnAddTable);
            panel25.Location = new Point(6, 12);
            panel25.Name = "panel25";
            panel25.Size = new Size(415, 49);
            panel25.TabIndex = 7;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(330, 0);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(85, 49);
            btnShowTable.TabIndex = 0;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(219, 0);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(85, 49);
            btnEditTable.TabIndex = 0;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(108, 0);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(85, 49);
            btnDeleteTable.TabIndex = 0;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(0, 0);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(85, 49);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(9, 66);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowTemplate.Height = 25;
            dtgvTable.Size = new Size(412, 381);
            dtgvTable.TabIndex = 10;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel15);
            tpFoodCategory.Controls.Add(panel21);
            tpFoodCategory.Controls.Add(dtgvCategory);
            tpFoodCategory.Location = new Point(4, 24);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(743, 450);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục ";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            panel15.Controls.Add(panel18);
            panel15.Controls.Add(panel19);
            panel15.Location = new Point(428, 61);
            panel15.Name = "panel15";
            panel15.Size = new Size(312, 379);
            panel15.TabIndex = 9;
            // 
            // panel18
            // 
            panel18.Controls.Add(txbCategoryName);
            panel18.Controls.Add(label7);
            panel18.Location = new Point(0, 64);
            panel18.Name = "panel18";
            panel18.Size = new Size(310, 58);
            panel18.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(123, 17);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(181, 23);
            txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 17);
            label7.Name = "label7";
            label7.Size = new Size(77, 27);
            label7.TabIndex = 0;
            label7.Text = "Tên bàn";
            // 
            // panel19
            // 
            panel19.Controls.Add(txbCategoryID);
            panel19.Controls.Add(label8);
            panel19.Location = new Point(0, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(310, 58);
            panel19.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(123, 17);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(181, 23);
            txbCategoryID.TabIndex = 1;
            txbCategoryID.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 17);
            label8.Name = "label8";
            label8.Size = new Size(32, 27);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel21
            // 
            panel21.Controls.Add(btnShowCategory);
            panel21.Controls.Add(btnEditCategory);
            panel21.Controls.Add(btnDeleteCategory);
            panel21.Controls.Add(btnAddCategory);
            panel21.Location = new Point(3, 6);
            panel21.Name = "panel21";
            panel21.Size = new Size(415, 49);
            panel21.TabIndex = 7;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(330, 0);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(85, 49);
            btnShowCategory.TabIndex = 0;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(219, 0);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(85, 49);
            btnEditCategory.TabIndex = 0;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(108, 0);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(85, 49);
            btnDeleteCategory.TabIndex = 0;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(0, 0);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(85, 49);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 61);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowTemplate.Height = 25;
            dtgvCategory.Size = new Size(412, 381);
            dtgvCategory.TabIndex = 10;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel10);
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel5);
            tpFood.Location = new Point(4, 24);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(743, 450);
            tpFood.TabIndex = 1;
            tpFood.Text = "Món ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel14);
            panel10.Controls.Add(panel13);
            panel10.Controls.Add(panel12);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(427, 63);
            panel10.Name = "panel10";
            panel10.Size = new Size(312, 379);
            panel10.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.Controls.Add(nmFoodPrice);
            panel14.Controls.Add(label4);
            panel14.Location = new Point(0, 192);
            panel14.Name = "panel14";
            panel14.Size = new Size(310, 58);
            panel14.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(97, 17);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(207, 23);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(43, 27);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel13
            // 
            panel13.Controls.Add(cbFoodCategory);
            panel13.Controls.Add(label3);
            panel13.Location = new Point(0, 128);
            panel13.Name = "panel13";
            panel13.Size = new Size(310, 58);
            panel13.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(97, 17);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(207, 23);
            cbFoodCategory.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(97, 27);
            label3.TabIndex = 0;
            label3.Text = "Danh mục: ";
            // 
            // panel12
            // 
            panel12.Controls.Add(txbFoodName);
            panel12.Controls.Add(label2);
            panel12.Location = new Point(0, 64);
            panel12.Name = "panel12";
            panel12.Size = new Size(310, 58);
            panel12.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(97, 17);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(207, 23);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel11
            // 
            panel11.Controls.Add(txbFoodID);
            panel11.Controls.Add(label1);
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(310, 58);
            panel11.TabIndex = 1;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(97, 17);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(207, 23);
            txbFoodID.TabIndex = 1;
            txbFoodID.Text = " ";
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(32, 27);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(427, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(310, 49);
            panel6.TabIndex = 4;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(3, 14);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(216, 23);
            txbSearchFoodName.TabIndex = 1;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(225, 0);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(85, 49);
            btnSearchFood.TabIndex = 0;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(6, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(415, 49);
            panel4.TabIndex = 3;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(330, 0);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(85, 49);
            btnShowFood.TabIndex = 0;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(219, 0);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(85, 49);
            btnEditFood.TabIndex = 0;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(108, 0);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(85, 49);
            btnDeleteFood.TabIndex = 0;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(0, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(85, 49);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtgvFood);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(6, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(415, 380);
            panel5.TabIndex = 2;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 0);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowTemplate.Height = 25;
            dtgvFood.Size = new Size(412, 381);
            dtgvFood.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(421, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(310, 394);
            panel8.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Location = new Point(421, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(310, 394);
            panel9.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Location = new Point(421, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(310, 394);
            panel7.TabIndex = 5;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel3);
            tpBill.Controls.Add(dtgvBill);
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(743, 450);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnViewBill);
            panel3.Controls.Add(dtpkToDate);
            panel3.Controls.Add(dtpkFromDate);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 32);
            panel3.TabIndex = 2;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(325, 2);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(84, 28);
            btnViewBill.TabIndex = 1;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(519, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(209, 23);
            dtpkToDate.TabIndex = 0;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(209, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(6, 44);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowTemplate.Height = 25;
            dtgvBill.Size = new Size(731, 400);
            dtgvBill.TabIndex = 1;
            // 
            // tcAdmin
            // 
            tcAdmin.AccessibleRole = AccessibleRole.None;
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(751, 478);
            tcAdmin.TabIndex = 0;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 497);
            Controls.Add(tcAdmin);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN";
            tpAccount.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).EndInit();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            tpTable.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel16.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            tpFood.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel8.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tcAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tpAccount;
        private TabPage tpTable;
        private TabPage tpFoodCategory;
        private TabPage tpFood;
        private TabPage tpBill;
        private TabControl tcAdmin;
        private Panel panel3;
        private DataGridView dtgvBill;
        private DateTimePicker dtpkFromDate;
        private DateTimePicker dtpkToDate;
        private Button btnViewBill;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Panel panel7;
        private Panel panel10;
        private Button btnAddFood;
        private DataGridView dtgvFood;
        private Button btnEditFood;
        private Button btnShowFood;
        private Button btnDeleteFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel11;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel13;
        private Label label3;
        private Panel panel12;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel14;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private ComboBox cbFoodCategory;
        private Panel panel15;
        private Panel panel18;
        private TextBox txbCategoryName;
        private Label label7;
        private Panel panel19;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel21;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private DataGridView dtgvCategory;
        private Panel panel16;
        private Panel panel22;
        private TextBox textBox1;
        private Label label9;
        private Panel panel23;
        private TextBox textBox2;
        private Label label10;
        private Panel panel25;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private DataGridView dtgvTable;
        private Panel panel24;
        private ComboBox cbTableStatus;
        private Label label11;
        private Panel panel1;
        private Panel panel17;
        private Label label6;
        private Panel panel20;
        private TextBox txbDisplayName;
        private Label label12;
        private Panel panel26;
        private TextBox txbUserName;
        private Label label13;
        private Panel panel28;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private DataGridView dtgvAccount;
        private Button btnResetPassword;
        private NumericUpDown nmAccountType;
    }
}