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
			components = new System.ComponentModel.Container();
			Panel panel2;
			checkBox1 = new CheckBox();
			btnRegister = new customizeButtons();
			btnLogin = new customizeButtons();
			pictureBox4 = new PictureBox();
			pictureBox3 = new PictureBox();
			txtPass = new TextBox();
			txtUser = new TextBox();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			panel1 = new Panel();
			RunningText = new Label();
			lblexit = new Label();
			pictureBox2 = new PictureBox();
			timer = new System.Windows.Forms.Timer(components);
			panel2 = new Panel();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(255, 82, 83);
			panel2.Controls.Add(checkBox1);
			panel2.Controls.Add(btnRegister);
			panel2.Controls.Add(btnLogin);
			panel2.Controls.Add(pictureBox4);
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(txtPass);
			panel2.Controls.Add(txtUser);
			panel2.Location = new Point(452, 111);
			panel2.Name = "panel2";
			panel2.Size = new Size(325, 304);
			panel2.TabIndex = 6;
			panel2.UseWaitCursor = true;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			checkBox1.ForeColor = Color.White;
			checkBox1.Location = new Point(126, 207);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(139, 25);
			checkBox1.TabIndex = 10;
			checkBox1.Text = "Show password";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.UseWaitCursor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// btnRegister
			// 
			btnRegister.BackColor = Color.White;
			btnRegister.BackgroundColor = Color.White;
			btnRegister.BorderColor = Color.FromArgb(255, 82, 83);
			btnRegister.BorderRadius = 12;
			btnRegister.BorderSize = 0;
			btnRegister.FlatAppearance.BorderSize = 0;
			btnRegister.FlatStyle = FlatStyle.Flat;
			btnRegister.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnRegister.ForeColor = Color.FromArgb(255, 82, 83);
			btnRegister.Location = new Point(164, 252);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(90, 32);
			btnRegister.TabIndex = 9;
			btnRegister.Text = "Register";
			btnRegister.TextColor = Color.FromArgb(255, 82, 83);
			btnRegister.UseVisualStyleBackColor = false;
			btnRegister.UseWaitCursor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.White;
			btnLogin.BackgroundColor = Color.White;
			btnLogin.BorderColor = Color.FromArgb(255, 82, 83);
			btnLogin.BorderRadius = 12;
			btnLogin.BorderSize = 0;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogin.ForeColor = Color.FromArgb(255, 82, 83);
			btnLogin.Location = new Point(68, 252);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(90, 32);
			btnLogin.TabIndex = 8;
			btnLogin.Text = "Log in";
			btnLogin.TextColor = Color.FromArgb(255, 82, 83);
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.UseWaitCursor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources._334943619_606537104656910_1868755821071732830_n_removebg_preview;
			pictureBox4.Location = new Point(34, 157);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(33, 31);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 5;
			pictureBox4.TabStop = false;
			pictureBox4.UseWaitCursor = true;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources._334926410_520292446936064_6625710103926206793_n_removebg_preview;
			pictureBox3.Location = new Point(34, 96);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(33, 31);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 4;
			pictureBox3.TabStop = false;
			pictureBox3.UseWaitCursor = true;
			// 
			// txtPass
			// 
			txtPass.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtPass.Location = new Point(73, 157);
			txtPass.Name = "txtPass";
			txtPass.PasswordChar = '*';
			txtPass.Size = new Size(192, 31);
			txtPass.TabIndex = 1;
			txtPass.UseWaitCursor = true;
			// 
			// txtUser
			// 
			txtUser.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtUser.Location = new Point(73, 96);
			txtUser.Name = "txtUser";
			txtUser.Size = new Size(192, 31);
			txtUser.TabIndex = 0;
			txtUser.UseWaitCursor = true;
			txtUser.TextChanged += txtUser_TextChanged;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.MistyRose;
			pictureBox1.Image = Properties.Resources.logo_g___fit_removebg_preview1;
			pictureBox1.Location = new Point(21, 95);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(287, 252);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Corbel", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.IndianRed;
			label1.Location = new Point(21, 31);
			label1.Name = "label1";
			label1.Size = new Size(181, 45);
			label1.TabIndex = 1;
			label1.Text = "Welcome !";
			// 
			// panel1
			// 
			panel1.BackColor = Color.MistyRose;
			panel1.Controls.Add(RunningText);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(342, 501);
			panel1.TabIndex = 2;
			// 
			// RunningText
			// 
			RunningText.AccessibleRole = AccessibleRole.MenuBar;
			RunningText.BorderStyle = BorderStyle.Fixed3D;
			RunningText.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			RunningText.ForeColor = SystemColors.WindowFrame;
			RunningText.Location = new Point(3, 468);
			RunningText.Name = "RunningText";
			RunningText.Size = new Size(327, 33);
			RunningText.TabIndex = 2;
			RunningText.Text = " Open Mon - Sat / 8:00am - 10:00pm";
			// 
			// lblexit
			// 
			lblexit.AutoSize = true;
			lblexit.BackColor = Color.Transparent;
			lblexit.Cursor = Cursors.Hand;
			lblexit.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblexit.ForeColor = Color.Red;
			lblexit.Location = new Point(863, 9);
			lblexit.Name = "lblexit";
			lblexit.Size = new Size(32, 33);
			lblexit.TabIndex = 5;
			lblexit.Text = "X";
			lblexit.Click += lblexit_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.FromArgb(255, 82, 83);
			pictureBox2.BackgroundImageLayout = ImageLayout.Center;
			pictureBox2.Image = Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			pictureBox2.Location = new Point(560, 59);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(95, 94);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Tick += timer_Tick;
			// 
			// Starting_page
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.background_gfit1;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(907, 500);
			Controls.Add(pictureBox2);
			Controls.Add(panel2);
			Controls.Add(lblexit);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Font = new Font("Corbel", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Starting_page";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Starting_page";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
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