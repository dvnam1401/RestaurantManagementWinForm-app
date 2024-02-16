namespace RestaurantManagement
{
    partial class frmAccountProfile
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
            panel1 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 58);
            panel1.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(143, 23);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(350, 23);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbDisplayName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 58);
            panel2.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(143, 23);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(350, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 19);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 58);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(143, 23);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(350, 23);
            txbPassWord.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(87, 29);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 58);
            panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(143, 23);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(350, 23);
            txbNewPass.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 19);
            label4.Name = "label4";
            label4.Size = new Size(118, 29);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(515, 58);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(143, 23);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(350, 23);
            txbReEnterPass.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(80, 29);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(343, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(433, 346);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(544, 414);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}