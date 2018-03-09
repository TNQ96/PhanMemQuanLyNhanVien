namespace EmployeeManagerment_UI.User
{
    partial class SuppliesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_isreturn = new System.Windows.Forms.CheckBox();
            this.txt_statusafter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_statusbefore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grid_listsupplies = new System.Windows.Forms.DataGridView();
            this.dtp_datereturn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_dateborrow = new System.Windows.Forms.DateTimePicker();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_namesupplies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_firstname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_reasonborrow = new System.Windows.Forms.TabPage();
            this.rtxt_reasonborrow = new System.Windows.Forms.RichTextBox();
            this.btn_addsupplies = new System.Windows.Forms.Button();
            this.btn_deletesupplies = new System.Windows.Forms.Button();
            this.btn_editsupplies = new System.Windows.Forms.Button();
            this.btn_reloadsupplies = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_backsupplies = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listsupplies)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_reasonborrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Untitled_1_01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cb_isreturn);
            this.panel1.Controls.Add(this.txt_statusafter);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_statusbefore);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.grid_listsupplies);
            this.panel1.Controls.Add(this.dtp_datereturn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp_dateborrow);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_namesupplies);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbb_firstname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbb_position);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbb_department);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(195, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_isreturn
            // 
            this.cb_isreturn.AutoSize = true;
            this.cb_isreturn.BackColor = System.Drawing.Color.Transparent;
            this.cb_isreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_isreturn.ForeColor = System.Drawing.Color.White;
            this.cb_isreturn.Location = new System.Drawing.Point(368, 151);
            this.cb_isreturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_isreturn.Name = "cb_isreturn";
            this.cb_isreturn.Size = new System.Drawing.Size(95, 28);
            this.cb_isreturn.TabIndex = 10;
            this.cb_isreturn.Text = "Đã trả !";
            this.cb_isreturn.UseVisualStyleBackColor = false;
            this.cb_isreturn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_statusafter
            // 
            this.txt_statusafter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusafter.Location = new System.Drawing.Point(522, 114);
            this.txt_statusafter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_statusafter.Name = "txt_statusafter";
            this.txt_statusafter.Size = new System.Drawing.Size(122, 29);
            this.txt_statusafter.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(368, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tình trạng sau:";
            // 
            // txt_statusbefore
            // 
            this.txt_statusbefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusbefore.Location = new System.Drawing.Point(522, 79);
            this.txt_statusbefore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_statusbefore.Name = "txt_statusbefore";
            this.txt_statusbefore.Size = new System.Drawing.Size(122, 29);
            this.txt_statusbefore.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(368, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tình trạng trước:";
            // 
            // grid_listsupplies
            // 
            this.grid_listsupplies.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid_listsupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listsupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_listsupplies.Location = new System.Drawing.Point(0, 292);
            this.grid_listsupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid_listsupplies.Name = "grid_listsupplies";
            this.grid_listsupplies.RowTemplate.Height = 28;
            this.grid_listsupplies.Size = new System.Drawing.Size(666, 184);
            this.grid_listsupplies.TabIndex = 0;
            // 
            // dtp_datereturn
            // 
            this.dtp_datereturn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datereturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datereturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datereturn.Location = new System.Drawing.Point(522, 44);
            this.dtp_datereturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_datereturn.Name = "dtp_datereturn";
            this.dtp_datereturn.Size = new System.Drawing.Size(122, 29);
            this.dtp_datereturn.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(368, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày trả:";
            // 
            // dtp_dateborrow
            // 
            this.dtp_dateborrow.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateborrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateborrow.Location = new System.Drawing.Point(522, 8);
            this.dtp_dateborrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_dateborrow.Name = "dtp_dateborrow";
            this.dtp_dateborrow.Size = new System.Drawing.Size(122, 29);
            this.dtp_dateborrow.TabIndex = 6;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(193, 146);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(148, 29);
            this.txt_quantity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng:";
            // 
            // txt_namesupplies
            // 
            this.txt_namesupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namesupplies.Location = new System.Drawing.Point(193, 114);
            this.txt_namesupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_namesupplies.Name = "txt_namesupplies";
            this.txt_namesupplies.Size = new System.Drawing.Size(148, 29);
            this.txt_namesupplies.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên vật tư:";
            // 
            // cbb_firstname
            // 
            this.cbb_firstname.BackColor = System.Drawing.Color.White;
            this.cbb_firstname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_firstname.FormattingEnabled = true;
            this.cbb_firstname.Location = new System.Drawing.Point(193, 79);
            this.cbb_firstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_firstname.Name = "cbb_firstname";
            this.cbb_firstname.Size = new System.Drawing.Size(148, 32);
            this.cbb_firstname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhân viên:";
            // 
            // cbb_position
            // 
            this.cbb_position.BackColor = System.Drawing.Color.White;
            this.cbb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Nhân viên"});
            this.cbb_position.Location = new System.Drawing.Point(193, 44);
            this.cbb_position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(148, 32);
            this.cbb_position.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chức vụ:";
            // 
            // cbb_department
            // 
            this.cbb_department.BackColor = System.Drawing.Color.White;
            this.cbb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Items.AddRange(new object[] {
            "Kế toán",
            "Bảo vệ",
            "Công nghệ thông tin",
            "Kinh doanh",
            "Nhân sự"});
            this.cbb_department.Location = new System.Drawing.Point(193, 8);
            this.cbb_department.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(148, 32);
            this.cbb_department.TabIndex = 1;
            this.cbb_department.SelectedIndexChanged += new System.EventHandler(this.cbb_department_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(368, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày mượn:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bộ phận:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_reasonborrow);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 179);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 114);
            this.tabControl1.TabIndex = 22;
            // 
            // tab_reasonborrow
            // 
            this.tab_reasonborrow.Controls.Add(this.rtxt_reasonborrow);
            this.tab_reasonborrow.Location = new System.Drawing.Point(4, 33);
            this.tab_reasonborrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_reasonborrow.Name = "tab_reasonborrow";
            this.tab_reasonborrow.Size = new System.Drawing.Size(658, 77);
            this.tab_reasonborrow.TabIndex = 0;
            this.tab_reasonborrow.Text = "Lý do mượn";
            this.tab_reasonborrow.UseVisualStyleBackColor = true;
            // 
            // rtxt_reasonborrow
            // 
            this.rtxt_reasonborrow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtxt_reasonborrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_reasonborrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_reasonborrow.Location = new System.Drawing.Point(0, 0);
            this.rtxt_reasonborrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxt_reasonborrow.Name = "rtxt_reasonborrow";
            this.rtxt_reasonborrow.Size = new System.Drawing.Size(658, 77);
            this.rtxt_reasonborrow.TabIndex = 11;
            this.rtxt_reasonborrow.Text = "";
            // 
            // btn_addsupplies
            // 
            this.btn_addsupplies.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Thembtn_01;
            this.btn_addsupplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addsupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addsupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addsupplies.Location = new System.Drawing.Point(0, 131);
            this.btn_addsupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addsupplies.Name = "btn_addsupplies";
            this.btn_addsupplies.Size = new System.Drawing.Size(195, 50);
            this.btn_addsupplies.TabIndex = 12;
            this.btn_addsupplies.UseVisualStyleBackColor = true;
            // 
            // btn_deletesupplies
            // 
            this.btn_deletesupplies.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.xoabtn_01;
            this.btn_deletesupplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deletesupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deletesupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletesupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deletesupplies.Location = new System.Drawing.Point(0, 180);
            this.btn_deletesupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deletesupplies.Name = "btn_deletesupplies";
            this.btn_deletesupplies.Size = new System.Drawing.Size(195, 50);
            this.btn_deletesupplies.TabIndex = 13;
            this.btn_deletesupplies.UseVisualStyleBackColor = true;
            // 
            // btn_editsupplies
            // 
            this.btn_editsupplies.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.suabtn_01;
            this.btn_editsupplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editsupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editsupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editsupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editsupplies.Location = new System.Drawing.Point(0, 230);
            this.btn_editsupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editsupplies.Name = "btn_editsupplies";
            this.btn_editsupplies.Size = new System.Drawing.Size(195, 50);
            this.btn_editsupplies.TabIndex = 14;
            this.btn_editsupplies.UseVisualStyleBackColor = true;
            // 
            // btn_reloadsupplies
            // 
            this.btn_reloadsupplies.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.tailai;
            this.btn_reloadsupplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reloadsupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reloadsupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reloadsupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reloadsupplies.Location = new System.Drawing.Point(0, 280);
            this.btn_reloadsupplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reloadsupplies.Name = "btn_reloadsupplies";
            this.btn_reloadsupplies.Size = new System.Drawing.Size(195, 50);
            this.btn_reloadsupplies.TabIndex = 15;
            this.btn_reloadsupplies.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.sl_01;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(861, 130);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btn_backsupplies
            // 
            this.btn_backsupplies.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Trolaibtn_01;
            this.btn_backsupplies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_backsupplies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backsupplies.Location = new System.Drawing.Point(0, 520);
            this.btn_backsupplies.Name = "btn_backsupplies";
            this.btn_backsupplies.Size = new System.Drawing.Size(195, 48);
            this.btn_backsupplies.TabIndex = 42;
            this.btn_backsupplies.UseVisualStyleBackColor = true;
            // 
            // SuppliesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Untitled_1_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 607);
            this.Controls.Add(this.btn_backsupplies);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_reloadsupplies);
            this.Controls.Add(this.btn_editsupplies);
            this.Controls.Add(this.btn_deletesupplies);
            this.Controls.Add(this.btn_addsupplies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuppliesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppliesForm";
            this.Load += new System.EventHandler(this.SuppliesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listsupplies)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_reasonborrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_listsupplies;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_reasonborrow;
        private System.Windows.Forms.RichTextBox rtxt_reasonborrow;
        private System.Windows.Forms.Button btn_addsupplies;
        private System.Windows.Forms.Button btn_deletesupplies;
        private System.Windows.Forms.Button btn_editsupplies;
        private System.Windows.Forms.Button btn_reloadsupplies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.ComboBox cbb_firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_namesupplies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dateborrow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_datereturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_statusafter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_statusbefore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_isreturn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_backsupplies;
    }
}