namespace EmployeeMgmnt1
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DailySalTb = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            DOBTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            JDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            AddBtn = new Button();
            EditButton = new Button();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            EmpList = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmpList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(367, 29);
            label1.Name = "label1";
            label1.Size = new Size(236, 26);
            label1.TabIndex = 1;
            label1.Text = "Employee Managment System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(406, 149);
            label2.Name = "label2";
            label2.Size = new Size(156, 26);
            label2.TabIndex = 2;
            label2.Text = "Manage Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 257);
            label3.Name = "label3";
            label3.Size = new Size(111, 26);
            label3.TabIndex = 7;
            label3.Text = "Emplyee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTb.Location = new Point(12, 286);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(228, 32);
            EmpNameTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 321);
            label4.Name = "label4";
            label4.Size = new Size(120, 26);
            label4.TabIndex = 9;
            label4.Text = "Emplyee Gender";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 449);
            label5.Name = "label5";
            label5.Size = new Size(101, 26);
            label5.TabIndex = 13;
            label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(12, 383);
            label6.Name = "label6";
            label6.Size = new Size(152, 26);
            label6.TabIndex = 11;
            label6.Text = "Emplyee Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(12, 585);
            label7.Name = "label7";
            label7.Size = new Size(156, 26);
            label7.TabIndex = 17;
            label7.Text = "Emplyee Dailly Salary";
            // 
            // DailySalTb
            // 
            DailySalTb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DailySalTb.Location = new Point(12, 614);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new Size(228, 32);
            DailySalTb.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(12, 517);
            label8.Name = "label8";
            label8.Size = new Size(73, 26);
            label8.TabIndex = 15;
            label8.Text = "Join Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 737);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 11);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 76);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(12, 346);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(228, 34);
            GenCb.TabIndex = 21;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Location = new Point(12, 412);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(228, 34);
            DepCb.TabIndex = 22;
            // 
            // DOBTb
            // 
            DOBTb.Checked = true;
            DOBTb.CustomizableEdges = customizableEdges1;
            DOBTb.FillColor = Color.Teal;
            DOBTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Location = new Point(12, 478);
            DOBTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DOBTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DOBTb.Name = "DOBTb";
            DOBTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DOBTb.Size = new Size(228, 36);
            DOBTb.TabIndex = 24;
            DOBTb.Value = new DateTime(2024, 1, 15, 0, 17, 7, 482);
            // 
            // JDateTb
            // 
            JDateTb.Checked = true;
            JDateTb.CustomizableEdges = customizableEdges3;
            JDateTb.FillColor = Color.Teal;
            JDateTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.Location = new Point(12, 546);
            JDateTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            JDateTb.MinDate = new DateTime(2024, 1, 15, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            JDateTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            JDateTb.Size = new Size(228, 36);
            JDateTb.TabIndex = 25;
            JDateTb.Value = new DateTime(2024, 1, 15, 0, 17, 7, 482);
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.CausesValidation = false;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(12, 666);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 44);
            AddBtn.TabIndex = 26;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.CadetBlue;
            EditButton.CausesValidation = false;
            EditButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.Black;
            EditButton.Location = new Point(129, 666);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(111, 44);
            EditButton.TabIndex = 27;
            EditButton.Text = "Update";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(594, 103);
            label11.Name = "label11";
            label11.Size = new Size(53, 26);
            label11.TabIndex = 55;
            label11.Text = "Salary";
            label11.Click += label11_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(542, 103);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(701, 103);
            label9.Name = "label9";
            label9.Size = new Size(58, 26);
            label9.TabIndex = 61;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(649, 103);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 60;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(433, 103);
            label10.Name = "label10";
            label10.Size = new Size(99, 26);
            label10.TabIndex = 59;
            label10.Text = "Deaprtement";
            label10.Click += label10_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(381, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(307, 103);
            label12.Name = "label12";
            label12.Size = new Size(68, 26);
            label12.TabIndex = 57;
            label12.Text = "Emplyee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(258, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // EmpList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmpList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmpList.ColumnHeadersHeight = 25;
            EmpList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmpList.DefaultCellStyle = dataGridViewCellStyle3;
            EmpList.GridColor = Color.FromArgb(231, 229, 255);
            EmpList.Location = new Point(323, 286);
            EmpList.Name = "EmpList";
            EmpList.RowHeadersVisible = false;
            EmpList.RowTemplate.Height = 25;
            EmpList.Size = new Size(677, 360);
            EmpList.TabIndex = 62;
            EmpList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmpList.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmpList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmpList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmpList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmpList.ThemeStyle.BackColor = Color.White;
            EmpList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmpList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            EmpList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmpList.ThemeStyle.HeaderStyle.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmpList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmpList.ThemeStyle.HeaderStyle.Height = 25;
            EmpList.ThemeStyle.ReadOnly = false;
            EmpList.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmpList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmpList.ThemeStyle.RowsStyle.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmpList.ThemeStyle.RowsStyle.Height = 25;
            EmpList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmpList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmpList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.CausesValidation = false;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(605, 666);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 63;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1012, 748);
            Controls.Add(button1);
            Controls.Add(EmpList);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(label11);
            Controls.Add(pictureBox4);
            Controls.Add(EditButton);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(DailySalTb);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmpList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox DailySalTb;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker JDateTb;
        private Button AddBtn;
        private Button EditButton;
        private Label label11;
        private PictureBox pictureBox4;
        private Label label9;
        private PictureBox pictureBox5;
        private Label label10;
        private PictureBox pictureBox3;
        private Label label12;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView EmpList;
        private Button button1;
    }
}