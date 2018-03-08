namespace EmployeeManagerment_UI.User
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cbbdepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbremember = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbdepartment
            // 
            this.cbbdepartment.BackColor = System.Drawing.Color.White;
            this.cbbdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbbdepartment.FormattingEnabled = true;
            this.cbbdepartment.Items.AddRange(new object[] {
            "Kế toán",
            "Bảo vệ",
            "Công nghệ thông tin",
            "Kinh doanh",
            "Nhân sự"});
            this.cbbdepartment.Location = new System.Drawing.Point(447, 377);
            this.cbbdepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbbdepartment.Name = "cbbdepartment";
            this.cbbdepartment.Size = new System.Drawing.Size(176, 26);
            this.cbbdepartment.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(265, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbremember
            // 
            this.cbremember.AutoSize = true;
            this.cbremember.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbremember.Checked = true;
            this.cbremember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbremember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbremember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbremember.Location = new System.Drawing.Point(264, 380);
            this.cbremember.Margin = new System.Windows.Forms.Padding(4);
            this.cbremember.Name = "cbremember";
            this.cbremember.Size = new System.Drawing.Size(76, 24);
            this.cbremember.TabIndex = 17;
            this.cbremember.Text = "Show";
            this.cbremember.UseVisualStyleBackColor = false;
            this.cbremember.CheckedChanged += new System.EventHandler(this.cbremember_CheckedChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpassword.Location = new System.Drawing.Point(264, 331);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(359, 30);
            this.txtpassword.TabIndex = 15;
            // 
            // txtusername
            // 
            this.txtusername.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtusername.Location = new System.Drawing.Point(264, 266);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(359, 30);
            this.txtusername.TabIndex = 14;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(468, 428);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(143, 48);
            this.btnexit.TabIndex = 20;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EmployeeManagerment_UI.Properties.Resources.lgf_01;
            this.pictureBox1.Location = new System.Drawing.Point(207, 198);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bntlogin
            // 
            this.bntlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.bntlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntlogin.ForeColor = System.Drawing.Color.White;
            this.bntlogin.Location = new System.Drawing.Point(277, 428);
            this.bntlogin.Margin = new System.Windows.Forms.Padding(4);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(143, 48);
            this.bntlogin.TabIndex = 24;
            this.bntlogin.Text = "LOGIN";
            this.bntlogin.UseVisualStyleBackColor = false;
            this.bntlogin.Click += new System.EventHandler(this.bntlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(265, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 634);
            this.Controls.Add(this.bntlogin);
            this.Controls.Add(this.cbbdepartment);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbremember);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbdepartment;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbremember;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntlogin;
        private System.Windows.Forms.Label label1;
    }
}