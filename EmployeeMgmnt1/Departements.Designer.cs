namespace EmployeeMgmnt1
{
    partial class Departements
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
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departements));
            EditBtn = new Button();
            AddBtn = new Button();
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            DepNameTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            EmpLbl = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.CadetBlue;
            EditBtn.CausesValidation = false;
            EditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(117, 637);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(111, 44);
            EditBtn.TabIndex = 46;
            EditBtn.Text = "Mise à jour";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.CausesValidation = false;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(0, 637);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 44);
            AddBtn.TabIndex = 45;
            AddBtn.Text = "Ajouter";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DepList
            // 
            dataGridViewCellStyle28.BackColor = Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle29.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = Color.White;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            DepList.ColumnHeadersHeight = 25;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = Color.White;
            dataGridViewCellStyle30.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle30.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle30;
            DepList.GridColor = Color.FromArgb(231, 229, 255);
            DepList.Location = new Point(364, 291);
            DepList.Name = "DepList";
            DepList.RowHeadersVisible = false;
            DepList.RowTemplate.Height = 25;
            DepList.Size = new Size(619, 424);
            DepList.TabIndex = 42;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepList.ThemeStyle.BackColor = Color.White;
            DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 25;
            DepList.ThemeStyle.ReadOnly = false;
            DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DepList.ThemeStyle.RowsStyle.Height = 25;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 183);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(9, 262);
            label3.Name = "label3";
            label3.Size = new Size(141, 26);
            label3.TabIndex = 31;
            label3.Text = "Code de comapgnie";
            // 
            // DepNameTb
            // 
            DepNameTb.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepNameTb.Location = new Point(9, 291);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(228, 32);
            DepNameTb.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(396, 154);
            label2.Name = "label2";
            label2.Size = new Size(178, 26);
            label2.TabIndex = 29;
            label2.Text = "Gestion de compagnie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(374, 34);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 1;
            label1.Text = "Gestion de vols";
            label1.Click += label1_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(607, 262);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 47;
            label4.Text = "Departements List";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(591, 102);
            label11.Name = "label11";
            label11.Size = new Size(95, 26);
            label11.TabIndex = 53;
            label11.Text = "Réservations";
            label11.Click += label11_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(539, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(434, 102);
            label10.Name = "label10";
            label10.Size = new Size(88, 26);
            label10.TabIndex = 51;
            label10.Text = "Compagnie";
            label10.Click += label10_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(382, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpLbl.ForeColor = Color.Teal;
            EmpLbl.Location = new Point(308, 102);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(51, 26);
            EmpLbl.TabIndex = 49;
            EmpLbl.Text = "Client";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(744, 102);
            label5.Name = "label5";
            label5.Size = new Size(110, 26);
            label5.TabIndex = 55;
            label5.Text = "Se déconnecter";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(692, 102);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.CausesValidation = false;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(68, 687);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 56;
            button1.Text = "Effacer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(9, 336);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 58;
            label6.Text = "Code de vol";
            label6.Click += this.label6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 32);
            textBox1.TabIndex = 57;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(9, 400);
            label7.Name = "label7";
            label7.Size = new Size(140, 26);
            label7.TabIndex = 60;
            label7.Text = "Nom de comapgnie";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(9, 430);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 32);
            textBox2.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(9, 465);
            label8.Name = "label8";
            label8.Size = new Size(105, 26);
            label8.TabIndex = 62;
            label8.Text = "Vol disponible";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(9, 494);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 32);
            textBox3.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(9, 538);
            label9.Name = "label9";
            label9.Size = new Size(81, 26);
            label9.TabIndex = 64;
            label9.Text = "Prix de vol";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(9, 567);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 32);
            textBox4.TabIndex = 63;
            // 
            // Departements
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1012, 748);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label11);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(pictureBox3);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DepNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Departements";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departements";
            Load += Departements_Load;
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private TextBox DepNameTb;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label11;
        private PictureBox pictureBox4;
        private Label label10;
        private PictureBox pictureBox3;
        private Label EmpLbl;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox5;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
    }
}