namespace EmployeeMgmnt1
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            EditBtn = new Button();
            AddBtn = new Button();
            EmployeeCb = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            DaysTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            SalList = new Guna.UI2.WinForms.Guna2DataGridView();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalList).BeginInit();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.CadetBlue;
            EditBtn.CausesValidation = false;
            EditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(129, 666);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(111, 44);
            EditBtn.TabIndex = 46;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
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
            AddBtn.TabIndex = 45;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EmployeeCb
            // 
            EmployeeCb.FormattingEnabled = true;
            EmployeeCb.Items.AddRange(new object[] { "Male", "Female" });
            EmployeeCb.Location = new Point(12, 289);
            EmployeeCb.Name = "EmployeeCb";
            EmployeeCb.Size = new Size(228, 29);
            EmployeeCb.TabIndex = 40;
            EmployeeCb.SelectionChangeCommitted += EmployeeCb_SelectionChangeCommitted;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 76);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 737);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 11);
            panel2.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 445);
            label4.Name = "label4";
            label4.Size = new Size(123, 26);
            label4.TabIndex = 32;
            label4.Text = "Nombre de place";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 257);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 31;
            label3.Text = "Code Client";
            label3.Click += label3_Click;
            // 
            // DaysTb
            // 
            DaysTb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DaysTb.Location = new Point(12, 474);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(228, 32);
            DaysTb.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(413, 125);
            label2.Name = "label2";
            label2.Size = new Size(184, 26);
            label2.TabIndex = 29;
            label2.Text = "Gestion de Réservation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(367, 29);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 1;
            label1.Text = "Gestion de vols";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 83);
            panel1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(715, 89);
            label7.Name = "label7";
            label7.Size = new Size(110, 26);
            label7.TabIndex = 61;
            label7.Text = "Se déconnecter";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(663, 87);
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
            label10.Location = new Point(419, 89);
            label10.Name = "label10";
            label10.Size = new Size(88, 26);
            label10.TabIndex = 59;
            label10.Text = "Compagnie";
            label10.Click += label10_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(367, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(293, 87);
            label9.Name = "label9";
            label9.Size = new Size(51, 26);
            label9.TabIndex = 57;
            label9.Text = "Client";
            label9.Click += label9_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(244, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(568, 89);
            label11.Name = "label11";
            label11.Size = new Size(89, 26);
            label11.TabIndex = 63;
            label11.Text = "Réservation";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(523, 87);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            // 
            // SalList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            SalList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            SalList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            SalList.ColumnHeadersHeight = 25;
            SalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            SalList.DefaultCellStyle = dataGridViewCellStyle6;
            SalList.GridColor = Color.FromArgb(231, 229, 255);
            SalList.Location = new Point(293, 178);
            SalList.Name = "SalList";
            SalList.RowHeadersVisible = false;
            SalList.RowTemplate.Height = 25;
            SalList.Size = new Size(677, 360);
            SalList.TabIndex = 64;
            SalList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SalList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SalList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SalList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SalList.ThemeStyle.BackColor = Color.White;
            SalList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SalList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            SalList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SalList.ThemeStyle.HeaderStyle.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SalList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalList.ThemeStyle.HeaderStyle.Height = 25;
            SalList.ThemeStyle.ReadOnly = false;
            SalList.ThemeStyle.RowsStyle.BackColor = Color.White;
            SalList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalList.ThemeStyle.RowsStyle.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SalList.ThemeStyle.RowsStyle.Height = 25;
            SalList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SalList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SalList.CellContentClick += SalList_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(12, 353);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 29);
            comboBox1.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 321);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 65;
            label5.Text = "Code Vol";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(12, 417);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 29);
            comboBox2.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(12, 385);
            label6.Name = "label6";
            label6.Size = new Size(126, 26);
            label6.TabIndex = 67;
            label6.Text = "Code Réservation";
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1012, 748);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(SalList);
            Controls.Add(label11);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(EmployeeCb);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DaysTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button AddBtn;
        private ComboBox EmployeeCb;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private TextBox DaysTb;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label10;
        private PictureBox pictureBox3;
        private Label label9;
        private PictureBox pictureBox2;
        private Label label11;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2DataGridView SalList;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
    }
}