namespace RestaurantManagement
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(14, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 191);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(394, 138);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(79, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(290, 138);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 63);
            panel2.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(140, 18);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(361, 23);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 17);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 63);
            panel3.TabIndex = 0;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(140, 18);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(361, 23);
            txbPassWord.TabIndex = 2;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 17);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 213);
            Controls.Add(panel1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogin;
        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label2;
    }
}