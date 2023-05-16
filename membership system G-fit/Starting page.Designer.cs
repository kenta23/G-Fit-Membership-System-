namespace membership_system_G_fit
{
	partial class Starting_page
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Panel panel2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starting_page));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnRegister = new membership_system_G_fit.customizeButtons();
			this.btnLogin = new membership_system_G_fit.customizeButtons();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RunningText = new System.Windows.Forms.Label();
			this.lblexit = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			panel2 = new System.Windows.Forms.Panel();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			panel2.Controls.Add(this.checkBox1);
			panel2.Controls.Add(this.btnRegister);
			panel2.Controls.Add(this.btnLogin);
			panel2.Controls.Add(this.pictureBox4);
			panel2.Controls.Add(this.pictureBox3);
			panel2.Controls.Add(this.txtPass);
			panel2.Controls.Add(this.txtUser);
			panel2.Location = new System.Drawing.Point(441, 116);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(325, 304);
			panel2.TabIndex = 6;
			panel2.UseWaitCursor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(126, 207);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(139, 25);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Show password";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.UseWaitCursor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.White;
			this.btnRegister.BackgroundColor = System.Drawing.Color.White;
			this.btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.btnRegister.BorderRadius = 12;
			this.btnRegister.BorderSize = 0;
			this.btnRegister.FlatAppearance.BorderSize = 0;
			this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegister.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.btnRegister.Location = new System.Drawing.Point(164, 252);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(90, 32);
			this.btnRegister.TabIndex = 9;
			this.btnRegister.Text = "Register";
			this.btnRegister.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.UseWaitCursor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.White;
			this.btnLogin.BackgroundColor = System.Drawing.Color.White;
			this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.btnLogin.BorderRadius = 12;
			this.btnLogin.BorderSize = 0;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.btnLogin.Location = new System.Drawing.Point(68, 252);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(90, 32);
			this.btnLogin.TabIndex = 8;
			this.btnLogin.Text = "Log in";
			this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.UseWaitCursor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::membership_system_G_fit.Properties.Resources._334943619_606537104656910_1868755821071732830_n_removebg_preview;
			this.pictureBox4.Location = new System.Drawing.Point(34, 157);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(33, 31);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.UseWaitCursor = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::membership_system_G_fit.Properties.Resources._334926410_520292446936064_6625710103926206793_n_removebg_preview;
			this.pictureBox3.Location = new System.Drawing.Point(34, 96);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(33, 31);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.UseWaitCursor = true;
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPass.Location = new System.Drawing.Point(73, 157);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(192, 31);
			this.txtPass.TabIndex = 1;
			this.txtPass.UseWaitCursor = true;
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUser.Location = new System.Drawing.Point(73, 96);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(192, 31);
			this.txtUser.TabIndex = 0;
			this.txtUser.UseWaitCursor = true;
			this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
			this.pictureBox1.Image = global::membership_system_G_fit.Properties.Resources.logo_g___fit_removebg_preview1;
			this.pictureBox1.Location = new System.Drawing.Point(21, 95);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(287, 252);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.IndianRed;
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome !";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.RunningText);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(342, 501);
			this.panel1.TabIndex = 2;
			// 
			// RunningText
			// 
			this.RunningText.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.RunningText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.RunningText.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RunningText.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.RunningText.Location = new System.Drawing.Point(3, 468);
			this.RunningText.Name = "RunningText";
			this.RunningText.Size = new System.Drawing.Size(327, 33);
			this.RunningText.TabIndex = 2;
			this.RunningText.Text = " Open Mon - Sat / 8:00am - 10:00pm";
			// 
			// lblexit
			// 
			this.lblexit.AutoSize = true;
			this.lblexit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblexit.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblexit.ForeColor = System.Drawing.Color.Red;
			this.lblexit.Location = new System.Drawing.Point(863, 9);
			this.lblexit.Name = "lblexit";
			this.lblexit.Size = new System.Drawing.Size(32, 33);
			this.lblexit.TabIndex = 5;
			this.lblexit.Text = "X";
			this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.Image = global::membership_system_G_fit.Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			this.pictureBox2.Location = new System.Drawing.Point(549, 64);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(95, 94);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Starting_page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(907, 500);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(panel2);
			this.Controls.Add(this.lblexit);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Starting_page";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Starting_page";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Panel panel1;
		private Label lblexit;
		private CheckBox checkBox1;
		private customizeButtons btnRegister;
		private customizeButtons btnLogin;
		private PictureBox pictureBox4;
		private PictureBox pictureBox3;
		private TextBox txtPass;
		private TextBox txtUser;
		private PictureBox pictureBox2;
		private Label RunningText;
		private System.Windows.Forms.Timer timer;
	}
}