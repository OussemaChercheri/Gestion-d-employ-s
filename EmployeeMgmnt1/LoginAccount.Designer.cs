namespace EmployeeMgmnt1
{
    partial class LoginAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAccount));
            ResetBl = new Label();
            LoginBtn = new Button();
            PasswordTb = new TextBox();
            label3 = new Label();
            UNameTb = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ResetBl
            // 
            ResetBl.AutoSize = true;
            ResetBl.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            ResetBl.ForeColor = Color.Teal;
            ResetBl.Location = new Point(376, 348);
            ResetBl.Name = "ResetBl";
            ResetBl.Size = new Size(35, 15);
            ResetBl.TabIndex = 17;
            ResetBl.Text = "Reset";
            ResetBl.Click += ResetBl_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.CausesValidation = false;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.Teal;
            LoginBtn.Location = new Point(344, 289);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(101, 44);
            LoginBtn.TabIndex = 16;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(316, 260);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(161, 23);
            PasswordTb.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(316, 236);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(316, 210);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(161, 23);
            UNameTb.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(316, 186);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 12;
            label2.Text = "Userame";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(285, 26);
            label1.Name = "label1";
            label1.Size = new Size(234, 18);
            label1.TabIndex = 10;
            label1.Text = "Employee Manger System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 438);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 232);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 20;
            label6.Text = "SQL Server";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(78, 182);
            label5.Name = "label5";
            label5.Size = new Size(35, 25);
            label5.TabIndex = 19;
            label5.Text = "C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 126);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 18;
            label4.Text = "Employee MS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(585, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 32);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 421);
            Controls.Add(pictureBox2);
            Controls.Add(ResetBl);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(label3);
            Controls.Add(UNameTb);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResetBl;
        private Button LoginBtn;
        private TextBox PasswordTb;
        private Label label3;
        private TextBox UNameTb;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
    }
}