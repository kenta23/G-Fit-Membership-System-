namespace membership_system_G_fit
{
	partial class Archives
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
			label1 = new Label();
			lblWelcome = new Label();
			pictureBox1 = new PictureBox();
			datagridviewArchives = new DataGridView();
			customizeButtons2 = new customizeButtons();
			btnRetrieve = new customizeButtons();
			btnDelete = new customizeButtons();
			lblCustomerID = new Label();
			label14 = new Label();
			joinDate = new DateTimePicker();
			label12 = new Label();
			cmbGender = new ComboBox();
			label11 = new Label();
			txtAge = new TextBox();
			label10 = new Label();
			txtZipCode = new TextBox();
			label9 = new Label();
			txtCity = new TextBox();
			label8 = new Label();
			txtBarangay = new TextBox();
			label7 = new Label();
			txtAddress = new TextBox();
			label6 = new Label();
			txtLastname = new TextBox();
			label5 = new Label();
			txtMiddlename = new TextBox();
			label4 = new Label();
			txtFirstname = new TextBox();
			label3 = new Label();
			txtUsername = new TextBox();
			label13 = new Label();
			txtPassword = new TextBox();
			label2 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)datagridviewArchives).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MistyRose;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(lblWelcome);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1034, 65);
			panel1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Cursor = Cursors.Hand;
			label1.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 82, 83);
			label1.Location = new Point(980, 17);
			label1.Name = "label1";
			label1.Size = new Size(32, 33);
			label1.TabIndex = 28;
			label1.Text = "X";
			label1.Click += label1_Click;
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			lblWelcome.ForeColor = Color.FromArgb(255, 82, 83);
			lblWelcome.Location = new Point(402, 17);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(199, 36);
			lblWelcome.TabIndex = 4;
			lblWelcome.Text = "G- FIT archives";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			pictureBox1.Location = new Point(36, 11);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(48, 49);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// datagridviewArchives
			// 
			datagridviewArchives.BackgroundColor = SystemColors.ControlLight;
			datagridviewArchives.BorderStyle = BorderStyle.Fixed3D;
			datagridviewArchives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			datagridviewArchives.GridColor = SystemColors.ControlLight;
			datagridviewArchives.Location = new Point(36, 106);
			datagridviewArchives.Name = "datagridviewArchives";
			datagridviewArchives.RowTemplate.Height = 25;
			datagridviewArchives.Size = new Size(825, 222);
			datagridviewArchives.TabIndex = 4;
			datagridviewArchives.CellClick += datagridviewArchives_CellClick;
			// 
			// customizeButtons2
			// 
			customizeButtons2.BackColor = Color.Red;
			customizeButtons2.BackgroundColor = Color.Red;
			customizeButtons2.BorderColor = Color.PaleVioletRed;
			customizeButtons2.BorderRadius = 12;
			customizeButtons2.BorderSize = 0;
			customizeButtons2.Cursor = Cursors.Hand;
			customizeButtons2.FlatAppearance.BorderSize = 0;
			customizeButtons2.FlatStyle = FlatStyle.Flat;
			customizeButtons2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			customizeButtons2.ForeColor = Color.White;
			customizeButtons2.Location = new Point(915, 674);
			customizeButtons2.Name = "customizeButtons2";
			customizeButtons2.Size = new Size(107, 35);
			customizeButtons2.TabIndex = 15;
			customizeButtons2.Text = "Back";
			customizeButtons2.TextColor = Color.White;
			customizeButtons2.UseVisualStyleBackColor = false;
			customizeButtons2.Click += customizeButtons2_Click;
			// 
			// btnRetrieve
			// 
			btnRetrieve.BackColor = Color.SpringGreen;
			btnRetrieve.BackgroundColor = Color.SpringGreen;
			btnRetrieve.BorderColor = Color.PaleVioletRed;
			btnRetrieve.BorderRadius = 12;
			btnRetrieve.BorderSize = 0;
			btnRetrieve.Cursor = Cursors.Hand;
			btnRetrieve.FlatAppearance.BorderSize = 0;
			btnRetrieve.FlatStyle = FlatStyle.Flat;
			btnRetrieve.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnRetrieve.ForeColor = Color.White;
			btnRetrieve.Location = new Point(885, 171);
			btnRetrieve.Name = "btnRetrieve";
			btnRetrieve.Size = new Size(127, 39);
			btnRetrieve.TabIndex = 16;
			btnRetrieve.Text = "Retrieve";
			btnRetrieve.TextColor = Color.White;
			btnRetrieve.UseVisualStyleBackColor = false;
			btnRetrieve.Click += btnRetrieve_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.DarkRed;
			btnDelete.BackgroundColor = Color.DarkRed;
			btnDelete.BorderColor = Color.PaleVioletRed;
			btnDelete.BorderRadius = 12;
			btnDelete.BorderSize = 0;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.FlatAppearance.BorderSize = 0;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(885, 249);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(127, 39);
			btnDelete.TabIndex = 17;
			btnDelete.Text = "Delete";
			btnDelete.TextColor = Color.White;
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// lblCustomerID
			// 
			lblCustomerID.AutoSize = true;
			lblCustomerID.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblCustomerID.ForeColor = Color.White;
			lblCustomerID.Location = new Point(207, 358);
			lblCustomerID.Name = "lblCustomerID";
			lblCustomerID.Size = new Size(18, 19);
			lblCustomerID.TabIndex = 85;
			lblCustomerID.Text = "*";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label14.ForeColor = Color.White;
			label14.Location = new Point(73, 351);
			label14.Name = "label14";
			label14.Size = new Size(128, 26);
			label14.TabIndex = 84;
			label14.Text = "Customer ID: ";
			// 
			// joinDate
			// 
			joinDate.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			joinDate.Format = DateTimePickerFormat.Custom;
			joinDate.Location = new Point(535, 575);
			joinDate.Name = "joinDate";
			joinDate.Size = new Size(117, 27);
			joinDate.TabIndex = 83;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label12.ForeColor = Color.White;
			label12.Location = new Point(442, 575);
			label12.Name = "label12";
			label12.Size = new Size(95, 26);
			label12.TabIndex = 82;
			label12.Text = "Join date:";
			// 
			// cmbGender
			// 
			cmbGender.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbGender.ForeColor = Color.Black;
			cmbGender.FormattingEnabled = true;
			cmbGender.Items.AddRange(new object[] { "Male ", "Female ", "Others" });
			cmbGender.Location = new Point(535, 443);
			cmbGender.Name = "cmbGender";
			cmbGender.Size = new Size(121, 27);
			cmbGender.TabIndex = 81;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label11.ForeColor = Color.White;
			label11.Location = new Point(457, 444);
			label11.Name = "label11";
			label11.Size = new Size(81, 26);
			label11.TabIndex = 80;
			label11.Text = "Gender:";
			// 
			// txtAge
			// 
			txtAge.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtAge.ForeColor = Color.Black;
			txtAge.Location = new Point(519, 395);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(102, 27);
			txtAge.TabIndex = 79;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label10.ForeColor = Color.White;
			label10.Location = new Point(457, 396);
			label10.Name = "label10";
			label10.Size = new Size(52, 26);
			label10.TabIndex = 78;
			label10.Text = "Age:";
			// 
			// txtZipCode
			// 
			txtZipCode.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtZipCode.ForeColor = Color.Black;
			txtZipCode.Location = new Point(191, 662);
			txtZipCode.Name = "txtZipCode";
			txtZipCode.Size = new Size(113, 27);
			txtZipCode.TabIndex = 77;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = Color.White;
			label9.Location = new Point(81, 663);
			label9.Name = "label9";
			label9.Size = new Size(91, 26);
			label9.TabIndex = 76;
			label9.Text = "Zip code:";
			// 
			// txtCity
			// 
			txtCity.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtCity.ForeColor = Color.Black;
			txtCity.Location = new Point(191, 619);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(204, 27);
			txtCity.TabIndex = 75;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = Color.White;
			label8.Location = new Point(120, 620);
			label8.Name = "label8";
			label8.Size = new Size(52, 26);
			label8.TabIndex = 74;
			label8.Text = "City:";
			// 
			// txtBarangay
			// 
			txtBarangay.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBarangay.ForeColor = Color.Black;
			txtBarangay.Location = new Point(191, 578);
			txtBarangay.Name = "txtBarangay";
			txtBarangay.Size = new Size(151, 27);
			txtBarangay.TabIndex = 73;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = Color.White;
			label7.Location = new Point(73, 576);
			label7.Name = "label7";
			label7.Size = new Size(99, 26);
			label7.TabIndex = 72;
			label7.Text = "Barangay:";
			// 
			// txtAddress
			// 
			txtAddress.BackColor = Color.White;
			txtAddress.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtAddress.ForeColor = Color.Black;
			txtAddress.Location = new Point(307, 529);
			txtAddress.Multiline = true;
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(290, 23);
			txtAddress.TabIndex = 71;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(73, 529);
			label6.Name = "label6";
			label6.Size = new Size(231, 26);
			label6.TabIndex = 70;
			label6.Text = "Address/House no/Street:";
			// 
			// txtLastname
			// 
			txtLastname.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtLastname.ForeColor = Color.Black;
			txtLastname.Location = new Point(191, 482);
			txtLastname.Name = "txtLastname";
			txtLastname.Size = new Size(204, 27);
			txtLastname.TabIndex = 69;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(73, 483);
			label5.Name = "label5";
			label5.Size = new Size(106, 26);
			label5.TabIndex = 68;
			label5.Text = "Last name:";
			// 
			// txtMiddlename
			// 
			txtMiddlename.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtMiddlename.ForeColor = Color.Black;
			txtMiddlename.Location = new Point(208, 440);
			txtMiddlename.Name = "txtMiddlename";
			txtMiddlename.Size = new Size(187, 27);
			txtMiddlename.TabIndex = 67;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(73, 441);
			label4.Name = "label4";
			label4.Size = new Size(129, 26);
			label4.TabIndex = 66;
			label4.Text = "Middle name:";
			// 
			// txtFirstname
			// 
			txtFirstname.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtFirstname.ForeColor = Color.Black;
			txtFirstname.Location = new Point(191, 393);
			txtFirstname.Name = "txtFirstname";
			txtFirstname.Size = new Size(204, 27);
			txtFirstname.TabIndex = 65;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(73, 393);
			label3.Name = "label3";
			label3.Size = new Size(108, 26);
			label3.TabIndex = 64;
			label3.Text = "First name:";
			// 
			// txtUsername
			// 
			txtUsername.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.ForeColor = Color.Black;
			txtUsername.Location = new Point(808, 392);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(204, 27);
			txtUsername.TabIndex = 87;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label13.ForeColor = Color.White;
			label13.Location = new Point(690, 392);
			label13.Name = "label13";
			label13.Size = new Size(105, 26);
			label13.TabIndex = 86;
			label13.Text = "Username:";
			label13.Click += label13_Click;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.ForeColor = Color.Black;
			txtPassword.Location = new Point(808, 446);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(204, 27);
			txtPassword.TabIndex = 89;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(690, 446);
			label2.Name = "label2";
			label2.Size = new Size(100, 26);
			label2.TabIndex = 88;
			label2.Text = "Password:";
			// 
			// Archives
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GrayText;
			ClientSize = new Size(1034, 721);
			Controls.Add(txtPassword);
			Controls.Add(label2);
			Controls.Add(txtUsername);
			Controls.Add(label13);
			Controls.Add(lblCustomerID);
			Controls.Add(label14);
			Controls.Add(joinDate);
			Controls.Add(label12);
			Controls.Add(cmbGender);
			Controls.Add(label11);
			Controls.Add(txtAge);
			Controls.Add(label10);
			Controls.Add(txtZipCode);
			Controls.Add(label9);
			Controls.Add(txtCity);
			Controls.Add(label8);
			Controls.Add(txtBarangay);
			Controls.Add(label7);
			Controls.Add(txtAddress);
			Controls.Add(label6);
			Controls.Add(txtLastname);
			Controls.Add(label5);
			Controls.Add(txtMiddlename);
			Controls.Add(label4);
			Controls.Add(txtFirstname);
			Controls.Add(label3);
			Controls.Add(btnDelete);
			Controls.Add(btnRetrieve);
			Controls.Add(customizeButtons2);
			Controls.Add(datagridviewArchives);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Archives";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Archives";
			Load += Archives_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)datagridviewArchives).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label lblWelcome;
		private PictureBox pictureBox1;
		private DataGridView datagridviewArchives;
		private customizeButtons customizeButtons2;
		private customizeButtons btnRetrieve;
		private customizeButtons btnDelete;
		private Label lblCustomerID;
		private Label label14;
		private DateTimePicker joinDate;
		private Label label12;
		private ComboBox cmbGender;
		private Label label11;
		private TextBox txtAge;
		private Label label10;
		private TextBox txtZipCode;
		private Label label9;
		private TextBox txtCity;
		private Label label8;
		private TextBox txtBarangay;
		private Label label7;
		private TextBox txtAddress;
		private Label label6;
		private TextBox txtLastname;
		private Label label5;
		private TextBox txtMiddlename;
		private Label label4;
		private TextBox txtFirstname;
		private Label label3;
		private TextBox txtUsername;
		private Label label13;
		private TextBox txtPassword;
		private Label label2;
	}
}