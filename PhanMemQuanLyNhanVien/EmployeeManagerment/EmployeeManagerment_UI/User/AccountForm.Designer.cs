namespace EmployeeManagerment_UI.User
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.btn_addaccount = new System.Windows.Forms.Button();
            this.btn_deleteaccount = new System.Windows.Forms.Button();
            this.btn_editaccount = new System.Windows.Forms.Button();
            this.btn_reloadaccount = new System.Windows.Forms.Button();
            this.btn_backaccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_isactiveaccount = new System.Windows.Forms.CheckBox();
            this.txt_accountlevel = new System.Windows.Forms.TextBox();
            this.txt_accountpassword = new System.Windows.Forms.TextBox();
            this.txt_accountname = new System.Windows.Forms.TextBox();
            this.cbb_firstname = new System.Windows.Forms.ComboBox();
            this.cbb_position = new System.Windows.Forms.ComboBox();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_listaccount = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listaccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addaccount
            // 
            this.btn_addaccount.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Thembtn_01;
            this.btn_addaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addaccount.Location = new System.Drawing.Point(-5, 160);
            this.btn_addaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addaccount.Name = "btn_addaccount";
            this.btn_addaccount.Size = new System.Drawing.Size(260, 62);
            this.btn_addaccount.TabIndex = 8;
            this.btn_addaccount.UseVisualStyleBackColor = true;
            this.btn_addaccount.Click += new System.EventHandler(this.btn_addaccount_Click);
            // 
            // btn_deleteaccount
            // 
            this.btn_deleteaccount.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.xoabtn_01;
            this.btn_deleteaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deleteaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deleteaccount.Location = new System.Drawing.Point(-5, 222);
            this.btn_deleteaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteaccount.Name = "btn_deleteaccount";
            this.btn_deleteaccount.Size = new System.Drawing.Size(260, 62);
            this.btn_deleteaccount.TabIndex = 9;
            this.btn_deleteaccount.UseVisualStyleBackColor = true;
            this.btn_deleteaccount.Click += new System.EventHandler(this.btn_deleteaccount_Click);
            // 
            // btn_editaccount
            // 
            this.btn_editaccount.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.suabtn_01;
            this.btn_editaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editaccount.Location = new System.Drawing.Point(-5, 283);
            this.btn_editaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editaccount.Name = "btn_editaccount";
            this.btn_editaccount.Size = new System.Drawing.Size(260, 62);
            this.btn_editaccount.TabIndex = 10;
            this.btn_editaccount.UseVisualStyleBackColor = true;
            this.btn_editaccount.Click += new System.EventHandler(this.btn_editaccount_Click);
            // 
            // btn_reloadaccount
            // 
            this.btn_reloadaccount.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.tailai;
            this.btn_reloadaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reloadaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reloadaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reloadaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reloadaccount.Location = new System.Drawing.Point(-5, 345);
            this.btn_reloadaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reloadaccount.Name = "btn_reloadaccount";
            this.btn_reloadaccount.Size = new System.Drawing.Size(260, 62);
            this.btn_reloadaccount.TabIndex = 11;
            this.btn_reloadaccount.UseVisualStyleBackColor = true;
            this.btn_reloadaccount.Click += new System.EventHandler(this.btn_reloadaccount_Click);
            // 
            // btn_backaccount
            // 
            this.btn_backaccount.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Trolaibtn_01;
            this.btn_backaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_backaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_backaccount.Location = new System.Drawing.Point(0, 640);
            this.btn_backaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backaccount.Name = "btn_backaccount";
            this.btn_backaccount.Size = new System.Drawing.Size(260, 62);
            this.btn_backaccount.TabIndex = 12;
            this.btn_backaccount.UseVisualStyleBackColor = true;
            this.btn_backaccount.Click += new System.EventHandler(this.btn_backaccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cb_isactiveaccount);
            this.panel1.Controls.Add(this.txt_accountlevel);
            this.panel1.Controls.Add(this.txt_accountpassword);
            this.panel1.Controls.Add(this.txt_accountname);
            this.panel1.Controls.Add(this.cbb_firstname);
            this.panel1.Controls.Add(this.cbb_position);
            this.panel1.Controls.Add(this.cbb_department);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grid_listaccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(254, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 577);
            this.panel1.TabIndex = 0;
            // 
            // cb_isactiveaccount
            // 
            this.cb_isactiveaccount.AutoSize = true;
            this.cb_isactiveaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_isactiveaccount.ForeColor = System.Drawing.Color.White;
            this.cb_isactiveaccount.Location = new System.Drawing.Point(491, 188);
            this.cb_isactiveaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_isactiveaccount.Name = "cb_isactiveaccount";
            this.cb_isactiveaccount.Size = new System.Drawing.Size(149, 35);
            this.cb_isactiveaccount.TabIndex = 7;
            this.cb_isactiveaccount.Text = "Kích hoạt";
            this.cb_isactiveaccount.UseVisualStyleBackColor = true;
            // 
            // txt_accountlevel
            // 
            this.txt_accountlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountlevel.Location = new System.Drawing.Point(696, 133);
            this.txt_accountlevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accountlevel.Name = "txt_accountlevel";
            this.txt_accountlevel.Size = new System.Drawing.Size(161, 34);
            this.txt_accountlevel.TabIndex = 6;
            // 
            // txt_accountpassword
            // 
            this.txt_accountpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountpassword.Location = new System.Drawing.Point(696, 70);
            this.txt_accountpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accountpassword.Name = "txt_accountpassword";
            this.txt_accountpassword.Size = new System.Drawing.Size(161, 34);
            this.txt_accountpassword.TabIndex = 5;
            // 
            // txt_accountname
            // 
            this.txt_accountname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountname.Location = new System.Drawing.Point(696, 10);
            this.txt_accountname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accountname.Name = "txt_accountname";
            this.txt_accountname.Size = new System.Drawing.Size(161, 34);
            this.txt_accountname.TabIndex = 4;
            // 
            // cbb_firstname
            // 
            this.cbb_firstname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_firstname.FormattingEnabled = true;
            this.cbb_firstname.Location = new System.Drawing.Point(257, 133);
            this.cbb_firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_firstname.Name = "cbb_firstname";
            this.cbb_firstname.Size = new System.Drawing.Size(196, 37);
            this.cbb_firstname.TabIndex = 3;
            // 
            // cbb_position
            // 
            this.cbb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Location = new System.Drawing.Point(257, 70);
            this.cbb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(196, 37);
            this.cbb_position.TabIndex = 2;
            this.cbb_position.SelectedIndexChanged += new System.EventHandler(this.cbb_position_SelectedIndexChanged);
            // 
            // cbb_department
            // 
            this.cbb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Items.AddRange(new object[] {
            "Kế toán",
            "Bảo vệ",
            "Công nghệ thông tin",
            "Kinh doanh",
            "Nhân sự"});
            this.cbb_department.Location = new System.Drawing.Point(257, 10);
            this.cbb_department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(196, 37);
            this.cbb_department.TabIndex = 1;
            this.cbb_department.SelectedIndexChanged += new System.EventHandler(this.cbb_department_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(491, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cấp độ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(491, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(491, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bộ phận:";
            // 
            // grid_listaccount
            // 
            this.grid_listaccount.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid_listaccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_listaccount.Location = new System.Drawing.Point(0, 262);
            this.grid_listaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_listaccount.Name = "grid_listaccount";
            this.grid_listaccount.RowTemplate.Height = 28;
            this.grid_listaccount.Size = new System.Drawing.Size(883, 315);
            this.grid_listaccount.TabIndex = 22;
            this.grid_listaccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_listaccount_CellClick);
            this.grid_listaccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_listaccount_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1137, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(499, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 69);
            this.label7.TabIndex = 13;
            this.label7.Text = "ACCOUNT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Untitled_1_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 737);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_backaccount);
            this.Controls.Add(this.btn_reloadaccount);
            this.Controls.Add(this.btn_editaccount);
            this.Controls.Add(this.btn_deleteaccount);
            this.Controls.Add(this.btn_addaccount);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listaccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addaccount;
        private System.Windows.Forms.Button btn_deleteaccount;
        private System.Windows.Forms.Button btn_editaccount;
        private System.Windows.Forms.Button btn_reloadaccount;
        private System.Windows.Forms.Button btn_backaccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_listaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.ComboBox cbb_firstname;
        private System.Windows.Forms.ComboBox cbb_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_accountname;
        private System.Windows.Forms.TextBox txt_accountlevel;
        private System.Windows.Forms.TextBox txt_accountpassword;
        private System.Windows.Forms.CheckBox cb_isactiveaccount;
        private System.Windows.Forms.Label label7;
    }
}